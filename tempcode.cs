Imports System.Data
Imports System.IO
Imports System.Text
Imports ExcelDataReader

Module ExcelToSQLFile

    Sub Main()
        ' Path to your Excel file
        Dim excelFilePath As String = "C:\path\to\your\file.xlsx"
        ' Output file path for SQL script
        Dim outputSqlFilePath As String = "C:\path\to\output.sql"

        ' Load data from Excel
        Dim sheets As DataTableCollection = LoadExcelFile(excelFilePath)

        ' Generate SQL scripts and write them to file
        GenerateSQLScriptsToFile(sheets, outputSqlFilePath)

        Console.WriteLine("SQL scripts have been saved to " & outputSqlFilePath)
    End Sub

    ' Function to load Excel file and get all sheets
    Private Function LoadExcelFile(filePath As String) As DataTableCollection
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)

        Using stream As FileStream = File.Open(filePath, FileMode.Open, FileAccess.Read)
            Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                Dim dataSet As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                    .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                        .UseHeaderRow = True ' Use the first row as headers
                    }
                })
                Return dataSet.Tables ' Return the collection of DataTables (sheets)
            End Using
        End Using
    End Function

    ' Function to generate CREATE TABLE and INSERT INTO scripts for each sheet and write to file
    Private Sub GenerateSQLScriptsToFile(sheets As DataTableCollection, outputFilePath As String)
        Using writer As New StreamWriter(outputFilePath, False, Encoding.UTF8)
            For Each sheet As DataTable In sheets
                Dim tableName As String = sheet.TableName
                Dim headers As List(Of String) = sheet.Columns.Cast(Of DataColumn).Select(Function(col) col.ColumnName).ToList()

                ' Generate CREATE TABLE and INSERT INTO scripts
                Dim createTableScript As String = GenerateCreateTableScript(tableName, headers)
                Dim insertIntoScript As String = GenerateInsertIntoScript(tableName, headers)

                ' Write to file
                writer.WriteLine("-- SQL Script for Table: " & tableName)
                writer.WriteLine(createTableScript)
                writer.WriteLine(insertIntoScript)
                writer.WriteLine()
            Next
        End Using
    End Sub

    ' Function to generate CREATE TABLE script
    Private Function GenerateCreateTableScript(tableName As String, headers As List(Of String)) As String
        Dim sb As New StringBuilder()
        sb.AppendLine($"CREATE TABLE [{tableName}] (")
        For Each header As String In headers
            Dim columnName As String = CleanColumnName(header)
            sb.AppendLine($"    [{columnName}] NVARCHAR(100),")
        Next
        sb.Length -= 3 ' Remove the last comma and newline
        sb.AppendLine(vbCrLf & ");")
        Return sb.ToString()
    End Function

    ' Function to generate INSERT INTO script
    Private Function GenerateInsertIntoScript(tableName As String, headers As List(Of String)) As String
        Dim sb As New StringBuilder()
        sb.AppendLine($"INSERT INTO [{tableName}] (")

        ' Add column names
        For Each header As String In headers
            Dim columnName As String = CleanColumnName(header)
            sb.Append($"[{columnName}], ")
        Next
        sb.Length -= 2 ' Remove the last comma and space
        sb.AppendLine(") VALUES (")

        ' Add placeholders for values
        For Each header As String In headers
            Dim columnName As String = CleanColumnName(header)
            sb.Append($"@{columnName}, ")
        Next
        sb.Length -= 2 ' Remove the last comma and space
        sb.AppendLine(");")

        Return sb.ToString()
    End Function

    ' Helper function to clean up column names by replacing special characters
    Private Function CleanColumnName(columnName As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(columnName.Trim(), "[^a-zA-Z0-9]", "_")
    End Function

End Module
