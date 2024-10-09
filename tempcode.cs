Private Sub SaveDataTableToCsvFile(dataTable As DataTable, csvFilePath As String)
        ' Define CSV configuration
        Dim config As New CsvConfiguration(CultureInfo.InvariantCulture) With {
            .HasHeaderRecord = True,
            .QuoteAllFields = True ' This ensures all fields are quoted
        }

        ' Write to CSV file
        Using writer As New StreamWriter(csvFilePath)
            Using csv As New CsvWriter(writer, config)
                ' Write the DataTable column headers
                For Each column As DataColumn In dataTable.Columns
                    csv.WriteField(column.ColumnName)
                Next
                csv.NextRecord()

                ' Write the DataTable rows
                For Each row As DataRow In dataTable.Rows
                    For Each column As DataColumn In dataTable.Columns
                        csv.WriteField(row(column).ToString())
                    Next
                    csv.NextRecord()
                Next
            End Using
        End Using
    End Sub
