using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        string sourceConnectionString = "YourSourceConnectionString";
        string destinationConnectionString = "YourDestinationConnectionString";
        string baseQuery = "SELECT * FROM SourceTable WHERE DateColumn >= @StartDate AND DateColumn < @EndDate";
        
        DateTime startDate = new DateTime(2020, 1, 1); // Start date of data transfer
        DateTime endDate = new DateTime(2020, 12, 31); // End date of data transfer
        TimeSpan batchInterval = TimeSpan.FromDays(1); // Interval for each batch

        for (DateTime batchStart = startDate; batchStart < endDate; batchStart += batchInterval)
        {
            DateTime batchEnd = batchStart + batchInterval;
            string query = baseQuery;

            var bufferBlock = new BufferBlock<DataTable>(
                new DataflowBlockOptions
                {
                    BoundedCapacity = 2 // Adjust based on memory availability
                });

            var actionBlock = new ActionBlock<DataTable>(
                data => BulkInsertData(data, destinationConnectionString),
                new ExecutionDataflowBlockOptions
                {
                    MaxDegreeOfParallelism = 1 // To maintain data integrity
                });

            bufferBlock.LinkTo(actionBlock, new DataflowLinkOptions { PropagateCompletion = true });

            // Read and buffer data for the current batch
            using (SqlConnection connection = new SqlConnection(sourceConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", batchStart);
                    command.Parameters.AddWithValue("@EndDate", batchEnd);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Table");
                    if (ds.Tables["Table"].Rows.Count > 0)
                    {
                        bufferBlock.Post(ds.Tables["Table"].Copy());
                    }
                }
            }

            bufferBlock.Complete();
            actionBlock.Completion.Wait();
        }
    }

    static void BulkInsertData(DataTable data, string destinationConnectionString)
    {
        using (SqlConnection destConnection = new SqlConnection(destinationConnectionString))
        {
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destConnection))
            {
                bulkCopy.DestinationTableName = "DestinationTable"; // Set your destination table name
                destConnection.Open();
                bulkCopy.WriteToServer(data);
            }
        }
    }
}
