CREATE PROCEDURE ExportDataToCSV
    @procedureName NVARCHAR(128),
    @outputFilePath NVARCHAR(256)
AS
BEGIN
    DECLARE @powershellCommand NVARCHAR(MAX)
    DECLARE @sqlCommand NVARCHAR(MAX)

    SET @sqlCommand = 'sqlcmd -S your_server_name -d your_database_name -U your_username -P your_password -Q "EXEC ' + @procedureName + '" -s"," -W -h -1 | findstr /R /V "^_"'

    SET @powershellCommand = 'powershell -Command "' + @sqlCommand + ' | Out-File -FilePath ' + @outputFilePath + ' -Encoding utf8BOM"'

    EXEC xp_cmdshell @powershellCommand
END
