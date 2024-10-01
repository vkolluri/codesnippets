# Parameters
$csvFile = "C:\path\to\your\file.csv"  # Path to your CSV file
$formatFile = "C:\path\to\your\formatfile.xml"  # Path to save the XML format file
$maxLength = 100  # Max length for VARCHAR columns (can be adjusted)

# Read the header from the CSV file
$header = (Get-Content $csvFile | Select-Object -First 1) -split ','

# Initialize XML content
$xmlContent = @"
<?xml version="1.0"?>
<BCPFORMAT xmlns="http://schemas.microsoft.com/sqlserver/2004/bulkload/format" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
    <RECORD>
"@

# Loop through each column in the header and create FIELD elements
for ($i = 1; $i -le $header.Length; $i++) {
    if ($i -eq $header.Length) {
        # Last column has a terminator for end of line
        $xmlContent += "        <FIELD ID=""$i"" xsi:type=""CharTerm"" TERMINATOR=""\"`\r\n"" MAX_LENGTH=""$maxLength"" COLLATION=""SQL_Latin1_General_CP1_CI_AS""/>`n"
    } else {
        # Columns with regular comma terminators
        $xmlContent += "        <FIELD ID=""$i"" xsi:type=""CharTerm"" TERMINATOR=""\"`,`"" MAX_LENGTH=""$maxLength"" COLLATION=""SQL_Latin1_General_CP1_CI_AS""/>`n"
    }
}

# Add ROW section to map columns to SQL table columns
$xmlContent += "    </RECORD>`n    <ROW>`n"

# Map columns to SQL Server table (assumed column names are same as CSV headers without quotes)
for ($i = 1; $i -le $header.Length; $i++) {
    $columnName = $header[$i - 1].Trim('"')  # Remove quotes from column names
    $xmlContent += "        <COLUMN SOURCE=""$i"" NAME=""$columnName"" xsi:type=""SQLVarchar""/>`n"
}

# Close the XML format structure
$xmlContent += "    </ROW>`n</BCPFORMAT>"

# Save the XML content to the format file
Set-Content -Path $formatFile -Value $xmlContent

# Output message
Write-Output "XML format file has been generated at: $formatFile"
