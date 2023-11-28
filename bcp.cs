using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string sourceConnectionString = "server=sourceServer;database=sourceDB;user id=userid;password=password;";
        string destinationConnectionString = "server=destinationServer;database=destinationDB;user id=userid;password=password;";
        string tableName = "yourTableName";
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), $"{tableName}.dat");

        // Export data from the source database
        ExportData(sourceConnectionString, tableName, filePath);

        // Import data into the destination database
        ImportData(destinationConnectionString, tableName, filePath);
    }

    static void ExportData(string connectionString, string tableName, string filePath)
    {
        string query = $"SELECT * FROM {tableName}";
        string bcpCommand = $"bcp \"{query}\" queryout \"{filePath}\" -c -t, -T -S {connectionString}";
        ExecuteBcpCommand(bcpCommand);
    }

    static void ImportData(string connectionString, string tableName, string filePath)
    {
        string bcpCommand = $"bcp {tableName} in \"{filePath}\" -c -t, -T -S {connectionString}";
        ExecuteBcpCommand(bcpCommand);
    }

    static void ExecuteBcpCommand(string command)
    {
        try
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "bcp.exe",
                Arguments = command,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(psi))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                }
                process.WaitForExit();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
