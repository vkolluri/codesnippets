public class FileEventAccumulator
{
    private readonly List<string> _filePaths = new List<string>();
    private readonly Timer _timer;
    private readonly IScheduler _scheduler;
    private readonly object _lock = new object();
    private bool _timerStarted = false; // Flag to indicate if the timer has been started
    private readonly TimeSpan _batchInterval = TimeSpan.FromMinutes(1);

    public FileEventAccumulator(IScheduler scheduler)
    {
        _scheduler = scheduler;
        // Timer does not start automatically
        _timer = new Timer(TimerCallback, null, Timeout.Infinite, Timeout.Infinite);
    }

    public void AddFileEvent(string filePath)
    {
        lock (_lock)
        {
            _filePaths.Add(filePath);
            // Start the timer only if it hasn't been started yet
            if (!_timerStarted)
            {
                _timer.Change(_batchInterval, Timeout.InfiniteTimeSpan);
                _timerStarted = true;
            }
        }
    }

    private void TimerCallback(object state)
    {
        List<string> filePathsToProcess = new List<string>();
        lock (_lock)
        {
            if (_filePaths.Count > 0)
            {
                filePathsToProcess.AddRange(_filePaths);
                _filePaths.Clear();
            }
            // Reset the flag so the timer can be started again for the next batch
            _timerStarted = false;
        }

        // Process available files and requeue unavailable ones
        ProcessAndRequeueFiles(filePathsToProcess).GetAwaiter().GetResult();
    }

    private async Task ProcessAndRequeueFiles(List<string> filePaths)
    {
        foreach (var filePath in filePaths)
        {
            if (IsFileReady(filePath))
            {
                Console.WriteLine($"Processing file: {filePath}");
                // Process the file
            }
            else
            {
                Console.WriteLine($"Requeuing file (not ready): {filePath}");
                // Requeue the file for the next batch
                AddFileEvent(filePath);
            }
        }
        // Trigger any job or action after processing
    }

    private bool IsFileReady(string filePath)
    {
        try
        {
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                // File can be opened for exclusive access
                return true;
            }
        }
        catch (IOException)
        {
            // The file is locked or in use
            return false;
        }
    }
}
