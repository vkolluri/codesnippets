# Load the ExcelDataReader assemblies
Add-Type -Path "C:\path\to\ExcelDataReader.dll"
Add-Type -Path "C:\path\to\ExcelDataReader.DataSet.dll"

# Define the path to your Excel file
$excelFilePath = "C:\path\to\your\file.xlsx"

# Open the Excel file and load each sheet into a DataSet
function LoadExcelFile {
    param (
        [string]$filePath
    )

    # Ensure ExcelDataReader uses the correct encoding
    [System.Text.Encoding]::RegisterProvider([System.Text.CodePagesEncodingProvider]::Instance)

    # Load the Excel file
    $stream = [System.IO.File]::Open($filePath, 'Open', 'Read')
    $reader = [ExcelDataReader.ExcelReaderFactory]::CreateReader($stream)

    # Configure to use headers
    $dataSetConfig = New-Object ExcelDataReader.ExcelDataSetConfiguration
    $dataSetConfig.ConfigureDataTable = { param($dataTableConfig) $dataTableConfig.UseHeaderRow = $true; return $dataTableConfig }

    # Read each sheet into a DataSet
    $dataSet = $reader.AsDataSet($dataSetConfig)
    $reader.Close()
    $stream.Close()

    return $dataSet.Tables
}

# Function to generate CREATE TABLE and INSERT INTO SQL scripts for each sheet
function GenerateSQLScripts {
    param (
        [System.Data.DataTableCollection]$sheets
    )

    foreach ($sheet in $sheets) {
        $tableName = $sheet.TableName

        # Get the headers (column names) from the DataTable
        $headers = $sheet.Columns | ForEach-Object { $_.ColumnName }

        # Generate CREATE TABLE script
        $createTableScript = Generate-CreateTableScript -tableName $tableName -headers $headers
        Write-Host "`nCREATE TABLE Script for $tableName:"
        Write-Host $createTableScript

        # Generate INSERT INTO script
        $insertIntoScript = Generate-InsertIntoScript -tableName $tableName -headers $headers
        Write-Host "`nINSERT INTO Script for $tableName:"
        Write-Host $insertIntoScript
    }
}

# Function to generate the CREATE TABLE script
function Generate-CreateTableScript {
    param (
        [string]$tableName,
        [array]$headers
    )

    $createTableScript = "CREATE TABLE [$tableName] (`n"
    foreach ($header in $headers) {
        # Clean column names by replacing special characters
        $columnName = $header.Trim() -replace '[^a-zA-Z0-9]', '_'
        $createTableScript += "    [$columnName] NVARCHAR(100),`n"
    }
    $createTableScript = $createTableScript.TrimEnd(",`n") + "`n);"
    return $createTableScript
}

# Function to generate the INSERT INTO script
function Generate-InsertIntoScript {
    param (
        [string]$tableName,
        [array]$headers
    )

    $insertIntoScript = "INSERT INTO [$tableName] (`n"
    foreach ($header in $headers) {
        $columnName = $header.Trim() -replace '[^a-zA-Z0-9]', '_'
        $insertIntoScript += "    [$columnName],"
    }
    $insertIntoScript = $insertIntoScript.TrimEnd(",") + "`n) VALUES (`n"
    foreach ($header in $headers) {
        $columnName = $header.Trim() -replace '[^a-zA-Z0-9]', '_'
        $insertIntoScript += "    @$columnName,"
    }
    $insertIntoScript = $insertIntoScript.TrimEnd(",") + "`n);"
    return $insertIntoScript
}

# Main script
$sheets = LoadExcelFile -filePath $excelFilePath
GenerateSQLScripts -sheets $sheets
