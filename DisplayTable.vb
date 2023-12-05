using System;
using System.Collections.Generic;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString1 = "Server=server1;Database=db1;User Id=user;Password=pass;";
        string connectionString2 = "Server=server2;Database=db2;User Id=user;Password=pass;";

        var checksums1 = GetChecksums(connectionString1, "Table1");
        var checksums2 = GetChecksums(connectionString2, "Table2");

        bool isEqual = CompareChecksums(checksums1, checksums2);
        Console.WriteLine($"Checksums are equal: {isEqual}");
    }

    static Dictionary<int, int> GetChecksums(string connectionString, string tableName)
    {
        string query = $"SELECT ID, BINARY_CHECKSUM(*) FROM {tableName}";
        var checksums = new Dictionary<int, int>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    int checksum = reader.GetInt32(1);
                    checksums[id] = checksum;
                }
            }
        }
        return checksums;
    }

    static bool CompareChecksums(Dictionary<int, int> checksums1, Dictionary<int, int> checksums2)
    {
        if (checksums1.Count != checksums2.Count)
            return false;

        foreach (var kvp in checksums1)
        {
            if (!checksums2.TryGetValue(kvp.Key, out int checksum2) || kvp.Value != checksum2)
                return false;
        }

        return true;
    }
}
