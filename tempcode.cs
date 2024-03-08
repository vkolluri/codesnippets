using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        FileSystemWatcher watcher = new FileSystemWatcher
        {
            Path = @"C:\path\to\watch",
            Filter = "*.*"
        };

        watcher.Created += async (sender, e) =>
        {
            Console.WriteLine($"File created: {e.FullPath}");
            try
            {
                await WaitForFileAvailable(e.FullPath, TimeSpan.FromSeconds(10));
                Console.WriteLine($"File is ready for processing: {e.FullPath}");
                // Proceed with processing the file
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine(ex.Message);
                // Handle the timeout, e.g., log the error or notify someone
            }
        };

        watcher.EnableRaisingEvents = true;

        Console.WriteLine("Press enter to exit.");
        Console.ReadLine();
    }

    static async Task WaitForFileAvailable(string filePath, TimeSpan timeout)
    {
        var start = DateTime.UtcNow;
        while (DateTime.UtcNow - start < timeout)
        {
            if (TryOpenFile(filePath))
            {
                return; // File is available
            }
            await Task.Delay(500); // Wait before trying again
        }
        throw new TimeoutException($"File {filePath} is not available after {timeout.TotalSeconds} seconds.");
    }

    static bool TryOpenFile(string filePath)
    {
        try
        {
            // Attempt to open the file exclusively.
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {
                return true; // Success, the file is not locked and can be processed
            }
        }
        catch (IOException)
        {
            // The file is still locked or in use
            return false;
        }
    }
}
