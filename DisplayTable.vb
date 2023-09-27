Imports System
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module Program
    Sub Main(args As String())
        Dim jsonString As String = ""

        ' Deserialize the JSON string
        Dim jsonObject As JObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)

        ' Generate the HTML table
        Dim htmlTable As String = ConvertJsonToHtmlTable(jsonObject)

        ' Display the HTML table
        Console.WriteLine(htmlTable)
    End Sub

    Function ConvertJsonToHtmlTable(token As JToken) As String
        If token Is Nothing Then
            Return String.Empty
        End If

        If token.Type = JTokenType.Object Then
            Dim html As String = "<table class='table table-bordered'>"
            For Each pair As JProperty In token.Children(Of JProperty)()
                html += $"<tr><td>{pair.Name}</td><td>{ConvertJsonToHtmlTable(pair.Value)}</td></tr>"
            Next
            html += "</table>"
            Return html
        ElseIf token.Type = JTokenType.Array Then
            Dim html As String = "<table class='table table-bordered'>"
            Dim index As Integer = 0
            For Each item As JToken In token.Children()
                html += $"<tr><td>[{index}]</td><td>{ConvertJsonToHtmlTable(item)}</td></tr>"
                index += 1
            Next
            html += "</table>"
            Return html
        Else
            Return token.ToString()
        End If
    End Function
End Module
