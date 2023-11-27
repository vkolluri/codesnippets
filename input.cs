using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        string sourceConnectionString = "YourSourceConnectionString";
        string destinationConnectionString = "YourDestinationConnectionString";
        string query = "SELECT * FROM SourceTable"; // Adjust your source query

        using (SqlConnection sourceConnection = new SqlConnection(sourceConnectionString))
        {
            sourceConnection.Open();
            using (SqlCommand command = new SqlCommand(query, sourceConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    using (SqlConnection destConnection = new SqlConnection(destinationConnectionString))
                    {
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destConnection))
                        {
                            bulkCopy.DestinationTableName = "DestinationTable"; // Set your destination table name
                            destConnection.Open();

                            // Optional: Map columns if they don't match exactly
                            // bulkCopy.ColumnMappings.Add("SourceColumn", "DestinationColumn");

                            bulkCopy.WriteToServer(reader);
                        }
                    }
                }
            }
        }
    }
}
