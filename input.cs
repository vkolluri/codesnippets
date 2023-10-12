Imports System
Imports System.Data
Imports Newtonsoft.Json.Linq

Public Class JsonToDataTableConverter
    Public Function ConvertJsonToDataTable(jsonString As String) As DataTable
        Dim json As JObject = JObject.Parse(jsonString)
        Dim dt As New DataTable()

        ParseJObject(json, dt, String.Empty)

        Return dt
    End Function

    Private Sub ParseJObject(obj As JObject, dt As DataTable, parentName As String)
        For Each property In obj.Properties()
            Dim columnName As String
            If String.IsNullOrEmpty(parentName) Then
                columnName = property.Name
            Else
                columnName = parentName & "." & property.Name
            End If

            If TypeOf property.Value Is JValue Then
                If Not dt.Columns.Contains(columnName) Then
                    dt.Columns.Add(columnName)
                End If
                If dt.Rows.Count = 0 Then
                    dt.Rows.Add()
                End If
                dt.Rows(dt.Rows.Count - 1)(columnName) = CType(property.Value, JValue).Value
            ElseIf TypeOf property.Value Is JArray Then
                Dim array As JArray = CType(property.Value, JArray)
                For Each item In array
                    If TypeOf item Is JObject Then
                        Dim newRow As DataRow = dt.NewRow()
                        dt.Rows.Add(newRow)
                        ParseJObject(CType(item, JObject), dt, columnName)
                    Else
                        If Not dt.Columns.Contains(columnName) Then
                            dt.Columns.Add(columnName)
                        End If
                        Dim newRow As DataRow = dt.NewRow()
                        newRow(columnName) = CType(item, JValue).Value
                        dt.Rows.Add(newRow)
                    End If
                Next
            ElseIf TypeOf property.Value Is JObject Then
                ParseJObject(CType(property.Value, JObject), dt, columnName)
            End If
        Next
    End Sub
End Class

Public Module Program
    Sub Main()
        Dim json As String = "..." ' Your JSON string
        Dim converter As New JsonToDataTableConverter()
        Dim dt As DataTable = converter.ConvertJsonToDataTable(json)

        ' Print the DataTable for demonstration
        For Each column As DataColumn In dt.Columns
            Console.Write(column.ColumnName & vbTab)
        Next
        Console.WriteLine()
        For Each row As DataRow In dt.Rows
            For Each column As DataColumn In dt.Columns
                Console.Write(row(column) & vbTab)
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
