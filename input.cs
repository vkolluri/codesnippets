Imports System
Imports System.Data
Imports Newtonsoft.Json.Linq

Public Class JsonToDataTableConverter
    Public Function ConvertJsonToDataTable(jsonString As String) As DataTable
        Dim json As JObject = JObject.Parse(jsonString)
        Dim dt As New DataTable()

        ' Define columns for DataTable
        dt.Columns.Add("reportingEntityLocationId")
        dt.Columns.Add("reportingEntityTransactionReference")
        dt.Columns.Add("dateTimeOfTransaction")
        dt.Columns.Add("methodCode")
        dt.Columns.Add("amount")
        dt.Columns.Add("currencyCode")
        dt.Columns.Add("conductorTypeCode")
        dt.Columns.Add("conductorRefId")
        dt.Columns.Add("dispositionCode")

        ' Iterate through transactions
        For Each transaction As JObject In json("transactions")
            Dim row As DataRow = dt.NewRow()
            row("reportingEntityLocationId") = transaction("reportingEntityLocationId").ToString()
            row("reportingEntityTransactionReference") = transaction("largeCashTransactionDetails")("reportingEntityTransactionReference").ToString()
            row("dateTimeOfTransaction") = transaction("largeCashTransactionDetails")("dateTimeOfTransaction").ToString()
            row("methodCode") = transaction("largeCashTransactionDetails")("methodCode").ToString()
            row("amount") = transaction("startingActions")(0)("details")("amount").ToString()
            row("currencyCode") = transaction("startingActions")(0)("details")("currencyCode").ToString()
            row("conductorTypeCode") = transaction("startingActions")(0)("conductors")(0)("typeCode").ToString()
            row("conductorRefId") = transaction("startingActions")(0)("conductors")(0)("refId").ToString()
            row("dispositionCode") = transaction("completingActions")(0)("details")("dispositionCode").ToString()

            dt.Rows.Add(row)
        Next

        Return dt
    End Function
End Class
