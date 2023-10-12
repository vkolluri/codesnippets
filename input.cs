 Public Function DefineColumnsFromJson(jsonString As String) As DataTable
        Dim json As JObject = JObject.Parse(jsonString)
        Dim dt As New DataTable()

        AddColumnsFromJObject(json, dt, String.Empty)

        Return dt
    End Function

    Private Sub AddColumnsFromJObject(obj As JObject, dt As DataTable, parentName As String)
        For Each property In obj.Properties()
            Dim columnName As String
            If String.IsNullOrEmpty(parentName) Then
                columnName = property.Name
            Else
                columnName = parentName & "." & property.Name
            End If

            If TypeOf property.Value Is JObject Then
                AddColumnsFromJObject(CType(property.Value, JObject), dt, columnName)
            ElseIf TypeOf property.Value Is JArray AndAlso CType(property.Value, JArray).Count > 0 AndAlso TypeOf CType(property.Value, JArray)(0) Is JObject Then
                AddColumnsFromJObject(CType(CType(property.Value, JArray)(0), JObject), dt, columnName)
            Else
                If Not dt.Columns.Contains(columnName) Then
                    dt.Columns.Add(columnName)
                End If
            End If
        Next
    End Sub
