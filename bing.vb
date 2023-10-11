Imports System
Imports System.Reflection
Imports Excel = Microsoft.Office.Interop.Excel

Class Program
    Private Shared Sub Main(ByVal args As String())
        Dim obj = New Person("Alice", 25, New Address("123 Main Street", "Acton", "ON"), New String() {"Bob", "Charlie", "David"})
        Dim type = obj.[GetType]()
        Dim properties = type.GetProperties()
        Dim excelApp = New Excel.Application()
        excelApp.Visible = False
        Dim workbook = CType((excelApp.Workbooks.Add("")), Excel._Workbook)
        Dim worksheet = CType(workbook.ActiveSheet, Excel._Worksheet)

        For i As Integer = 0 To properties.Length - 1
            worksheet.Cells(1, i + 1) = properties(i).Name
        Next

        For i As Integer = 0 To properties.Length - 1
            Dim value = properties(i).GetValue(obj)

            If properties(i).PropertyType.IsClass AndAlso properties(i).PropertyType <> GetType(String) OrElse properties(i).PropertyType.IsArray Then
                value = ""
            End If

            worksheet.Cells(2, i + 1) = value
        Next

        Dim currentRow As Integer = 3
        Dim array As Array = Nothing

        For Each [property] In properties

            If [property].PropertyType.IsClass AndAlso [property].PropertyType <> GetType(String) OrElse [property].PropertyType.IsArray Then
                Dim value = [property].GetValue(obj)
                worksheet.Cells(currentRow, 1) = [property].Name & ":"
                currentRow += 1

                If CSharpImpl.__Assign(array, TryCast(value, Array)) IsNot Nothing Then
                    worksheet.Cells(currentRow, 1) = "Index"
                    worksheet.Cells(currentRow, 2) = "Element"

                    For i As Integer = 0 To array.Length - 1
                        worksheet.Cells(currentRow + i + 1, 1) = i
                        worksheet.Cells(currentRow + i + 1, 2) = array.GetValue(i)
                    Next

                    currentRow += array.Length + 2
                Else
                    Dim valueType = value.[GetType]()
                    Dim valueProperties = valueType.GetProperties()

                    For i As Integer = 0 To valueProperties.Length - 1
                        worksheet.Cells(currentRow, i + 2) = valueProperties(i).Name
                    Next

                    For i As Integer = 0 To valueProperties.Length - 1
                        Dim subValue = valueProperties(i).GetValue(value)
                        worksheet.Cells(currentRow + 1, i + 2) = subValue
                    Next

                    currentRow += 3
                End If
            End If
        Next

        workbook.SaveAs("c:\test\test.xlsx", Excel.XlFileFormat.xlWorkbookDefault)
        workbook.Close()
        excelApp.Quit()
    End Sub

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class
