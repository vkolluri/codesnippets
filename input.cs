Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Reflection

Public Class ObjectFlattener
    Public Shared Sub FlattenAndPrint(obj As Object)
        Dim flattenedObject = Flatten(obj)
        Dim isPropertyRow As Boolean = True
        Dim propertyNames As New List(Of String)
        Dim propertyValues As New List(Of String)

        For Each kvp In flattenedObject
            If isPropertyRow Then
                propertyNames.Add(kvp.Key)
            Else
                propertyValues.Add(kvp.Value.ToString())
            End If

            isPropertyRow = Not isPropertyRow
        Next

        Console.WriteLine(String.Join(vbTab, propertyNames))
        Console.WriteLine(String.Join(vbTab, propertyValues))
    End Sub

    Private Shared Function Flatten(obj As Object) As Dictionary(Of String, Object)
        Return FlattenObject("", obj)
    End Function

    Private Shared Function FlattenObject(prefix As String, obj As Object) As Dictionary(Of String, Object)
        Dim result = New Dictionary(Of String, Object)()

        If obj Is Nothing Then
            result.Add(prefix, Nothing)
            Return result
        End If

        If TypeOf obj Is String OrElse TypeOf obj Is ValueType Then
            result.Add(prefix, obj)
            Return result
        End If

        If TypeOf obj Is IEnumerable(Of Object) Then
            Dim index As Integer = 0
            For Each item In DirectCast(obj, IEnumerable(Of Object))
                Dim itemPrefix = $"{prefix}[{index}]"
                result.Merge(FlattenObject(itemPrefix, item))
                index += 1
            Next
        Else
            For Each prop As PropertyInfo In obj.GetType().GetProperties()
                Dim propName = If(String.IsNullOrWhiteSpace(prefix), prop.Name, $"{prefix}.{prop.Name}")
                Dim propValue = prop.GetValue(obj)
                result.Merge(FlattenObject(propName, propValue))
            Next
        End If

        Return result
    End Function
End Class

Module DictionaryExtensions
    <System.Runtime.CompilerServices.Extension>
    Public Sub Merge(target As Dictionary(Of String, Object), source As Dictionary(Of String, Object))
        For Each item In source
            target(item.Key) = item.Value
        Next
    End Sub
End Module

Sub Main()
    Dim complexObject = New With {
        .Name = "John",
        .Age = 30,
        .Address = New With {
            .Street = "123 Main St",
            .City = "Sample City"
        },
        .Hobbies = New String() {"Reading", "Hiking"}
    }

    ObjectFlattener.FlattenAndPrint(complexObject)
End Sub
End Module
