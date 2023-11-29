function Copy-SQLTable
{
    [CmdletBinding()]
    param( 
 
        [Parameter(Mandatory=$true)]
        [string] $SourceInstance,
 
        [Parameter(Mandatory=$true)]
        [string] $SourceDB,        
 
        [Parameter(Mandatory=$true)]
        [string] $DestInstance,
 
        [Parameter(Mandatory=$true)]
        [string] $DestDB,
 
        [Parameter(Mandatory=$false)]
        [switch] $DropTargetTableIfExists = $false,
 
        [Parameter(Mandatory=$false)]
        [switch] $CopyIndexes = $true,
 
        [Parameter(Mandatory=$false)]
        [switch] $CopyConstraints = $false,
 
        [Parameter(Mandatory=$false)]
        [switch] $CopyData = $true,
 
        [Parameter(Mandatory=$true)]
        [string[]] $Tables,
 
        [Parameter(Mandatory=$false)]
        [int] $BulkCopyBatchSize = 10000,
 
        [Parameter(Mandatory=$false)]
        [int] $BulkCopyTimeout = 600   #10 minutes
 
    )
 
    [string] $fn = $MyInvocation.MyCommand
    [string] $stepName = "Begin [$fn]" 
 
    [string] $sourceConnString = "Data Source=$SourceInstance;Initial Catalog=$SourceDB;Integrated Security=True;"
    [string] $destConnString = "Data Source=$DestInstance;Initial Catalog=$DestDB;Integrated Security=True;"
    [int] $counter = 0
 
    try
    {    
 
        $stepName = "[$fn]: Import SQLPS module and initialize source connection"
        #---------------------------------------------------------------
        Write-Verbose $stepName
 
        Import-Module 'SQLPS'
        $sourceServer = New-Object Microsoft.SqlServer.Management.Smo.Server $SourceInstance
        $sourceDatabase = $sourceServer.Databases[$SourceDB]
        $sourceConn  = New-Object System.Data.SqlClient.SQLConnection($sourceConnString)
        $sourceConn.Open()
 
        foreach($table in $sourceDatabase.Tables)
        {
            $tableName = $table.Name
            $schemaName = $table.Schema
            $tableAndSchema = "$schemaName.$tableName"
 
            if ($Tables.Contains($tableAndSchema))
            {
                $counter = $counter + 1
                Write-Progress -Activity "Copy progress:" `
                            -PercentComplete ([int](100 * $counter / $Tables.Count)) `
                            -CurrentOperation ("Completed {0}% of the tables" -f ([int](100 * $counter / $Tables.Count))) `
                            -Status ("Working on table: [{0}]" -f $tableAndSchema) `
                            -Id 1
 
                Write-Verbose "[$fn]: ---------------------------------------------------------------"
                $stepName = "[$fn]: About to copy table [$tableAndSchema]"
                Write-Verbose $stepName
                Write-Verbose "[$fn]: ---------------------------------------------------------------"
 
                $stepName = "[$fn]: Create schema [$schemaName] in target if it does not exist"
                #---------------------------------------------------------------
                Write-Verbose $stepName
 
                $schemaScript = "IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = '$schemaName')
                                    BEGIN
                                        EXEC('CREATE SCHEMA $schemaName')
                                    END"
 
                Invoke-Sqlcmd `
                            -ServerInstance $DestInstance `
                            -Database $DestDB `
                            -Query $schemaScript
 
                if ($DropTargetTableIfExists -eq $true)
                {
                    Write-Verbose "[$fn]: Drop table [$tableName] in target if it exists"
                    #---------------------------------------------------------------
                    Write-Verbose $stepName
 
                    $schemaScript = "IF EXISTS (SELECT 1 WHERE OBJECT_ID('$tableAndSchema') IS NOT NULL)
                                        BEGIN
                                            EXEC('DROP TABLE $tableAndSchema')
                                        END"
 
                    Invoke-Sqlcmd `
                                -ServerInstance $DestInstance `
                                -Database $DestDB `
                                -Query $schemaScript
                }
 
                $stepName = "[$fn]: Scripting default scripting options - default"
                #----------------------------
                $scriptingCreateOptions = New-Object Microsoft.SqlServer.Management.Smo.ScriptingOptions
                Write-Verbose $stepName
 
                $scriptingCreateOptions.ExtendedProperties = $true; # Script Extended Properties
 
                #$scriptingCreateOptions.DriAllConstraints = $true   # to include referential constraints in the script
                #$scriptingCreateOptions.NoCollation = $false; # Use default collation
                #$scriptingCreateOptions.SchemaQualify = $true; # Qualify objects with schema names
                #$scriptingCreateOptions.ScriptSchema = $true; # Script schema
                #$scriptingCreateOptions.IncludeDatabaseContext = $true;
                #$scriptingCreateOptions.EnforceScriptingOptions = $true;
                #$scriptingCreateOptions.Indexes= $true # Yup, these would be nice
                #$scriptingCreateOptions.Triggers= $true # This should be included when scripting a database                
 
                $stepName = "[$fn]: Create constraints"
                #---------------------------------------------------------------
                Write-Verbose $stepName
 
                #Copy constraints
                if ($CopyConstraints -eq $true)
                {
                    $scriptingCreateOptions.DRIAll= $true     #All the constraints
                }
                else
                {
                    $scriptingCreateOptions.DRIAll= $false
                }
 
                $stepName = "[$fn]: Get the source table script for [$tableName] and create in target"
                #---------------------------------------------------------------
                Write-Verbose $stepName
 
                $Tablescript = ($table.Script($scriptingCreateOptions) | Out-String)
 
                Invoke-Sqlcmd `
                            -ServerInstance $DestInstance `
                            -Database $DestDB `
                            -Query $Tablescript
 
                #Only copy if needed. There may be a need to just copy table structures!
                if ($CopyData -eq $true)
                {
                    $stepName = "[$fn]: Get data reader for source table"
                    #---------------------------------------------------------------
                    Write-Verbose $stepName
 
                    $sql = "SELECT * FROM $tableAndSchema"
                    $sqlCommand = New-Object system.Data.SqlClient.SqlCommand($sql, $sourceConn)
                    [System.Data.SqlClient.SqlDataReader] $sqlReader = $sqlCommand.ExecuteReader()
 
                    $stepName = "[$fn]: Copy data from source to destination for table"
                    #---------------------------------------------------------------
                    Write-Verbose $stepName
 
                    $bulkCopy = New-Object Data.SqlClient.SqlBulkCopy($destConnString, [System.Data.SqlClient.SqlBulkCopyOptions]::KeepIdentity)
                    $bulkCopy.DestinationTableName = $tableAndSchema
                    $bulkCopy.BulkCopyTimeOut = $BulkCopyTimeout
                    $bulkCopy.BatchSize = $BulkCopyBatchSize
                    $bulkCopy.WriteToServer($sqlReader)
                    $sqlReader.Close()
                    $bulkCopy.Close()
                }
 
                #Do the index creations after the data load! That is the smarter thing to do.
                if ($CopyIndexes -eq $true)
                {
                    $stepName = "[$fn]: Create indexes for [$tableName] in target"
                    #---------------------------------------------------------------
                    Write-Verbose $stepName
 
                    foreach($index in $table.Indexes )
                    {
                        Write-Verbose "Creating index [$($index.Name)] for [$tableName]"
 
                        $indexScript = ($index.script() | Out-String)
 
                        Invoke-Sqlcmd `
                            -ServerInstance $DestInstance `
                            -Database $DestDB `
                            -Query $indexScript
                    }
                }
 
            }
        }
 
        Write-Verbose 'Cleanup'
        #---------------------------------------------------------------
 
        $sourceConn.Close()
 
    }
    catch
    {
        [Exception]$ex = $_.Exception
        Throw "Unable to copy table(s). Error in step: `"{0}]`" `n{1}" -f `
                        $stepName, $ex.Message
    }
    finally
    {
        #Return value if any
    }
}
