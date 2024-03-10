public class SequentialJobQueue
{
    private readonly ConcurrentQueue<JobDetail> _jobQueue = new ConcurrentQueue<JobDetail>();
    private readonly ManualResetEvent _newItemEvent = new ManualResetEvent(false);
    private readonly IScheduler _scheduler;
    private bool _isRunning = true;

    public SequentialJobQueue(IScheduler scheduler)
    {
        _scheduler = scheduler;
        Task.Run(() => ProcessQueue());
    }

    public void EnqueueJob<TJob>(string taskName) where TJob : IJob
    {
        IJobDetail job = JobBuilder.Create<TJob>()
            .UsingJobData("TaskName", taskName)
            .Build();

        _jobQueue.Enqueue(new JobDetail { Job = job });
        _newItemEvent.Set(); // Signal that a new item has been added
    }

    private void ProcessQueue()
    {
        while (_isRunning)
        {
            _newItemEvent.WaitOne(); // Wait for an item to be added

            while (_jobQueue.TryDequeue(out JobDetail jobDetail))
            {
                _scheduler.TriggerJob(jobDetail.Job.Key).Wait();
            }
            _newItemEvent.Reset(); // Reset the event until a new item is added
        }
    }

    public void Stop()
    {
        _isRunning = false;
        _newItemEvent.Set(); // Ensure we exit the wait state to stop the loop
    }

    private class JobDetail
    {
        public IJobDetail Job { get; set; }
    }
}
