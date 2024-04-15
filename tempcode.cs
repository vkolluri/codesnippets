SELECT
    ('<td>' + ISNULL(CAST(col1 AS NVARCHAR(MAX)), '') + '</td>' +
     '<td>' + ISNULL(CAST(col2 AS NVARCHAR(MAX)), '') + '</td>') AS 'tr'
FROM table1
FOR XML PATH(''), ROOT('table')
