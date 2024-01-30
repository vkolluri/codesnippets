using Quartz;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace QuartzConsoleApp
{
    public class StoredProcedureJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            // Retrieve job details, like the connection string and stored procedure name
            var connectionString = context.JobDetail.JobDataMap.GetString("connectionString");
            var storedProcedureName = context.JobDetail.JobDataMap.GetString("storedProcedureName");

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    using (var command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        // Add any parameters to the command here
                        await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL-specific errors
                // Log the exception and/or take specific actions
                throw new JobExecutionException($"SQL error occurred executing stored procedure: {ex.Message}", ex, false);
            }
            catch (Exception ex)
            {
                // Handle non-SQL errors
                // Log the exception and/or take specific actions
                throw new JobExecutionException($"Error occurred executing stored procedure: {ex.Message}", ex, false);
            }
        }
    }
}
