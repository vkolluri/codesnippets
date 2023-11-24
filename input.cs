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
        string query = "SELECT * FROM SourceTable"; // Adjust your query here
        int batchSize = 10000; // Batch size for reading data

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

        // Read and buffer data in batches
        using (SqlConnection connection = new SqlConnection(sourceConnectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                
                int numberOfRowsRead = 0;
                do
                {
                    ds.Clear();
                    numberOfRowsRead = adapter.Fill(ds, 0, batchSize, "Table");
                    if (numberOfRowsRead > 0)
                    {
                        bufferBlock.Post(ds.Tables["Table"].Copy());
                    }
                } while (numberOfRowsRead == batchSize);
            }
        }

        bufferBlock.Complete();
        actionBlock.Completion.Wait();
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
