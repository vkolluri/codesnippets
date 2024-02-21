using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Initialize StdSchedulerFactory
        ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
        // Get and start a scheduler
        IScheduler scheduler = await schedulerFactory.GetScheduler();
        await scheduler.Start();

        // Assuming you have already scheduled some jobs and triggers at this point

        // Fetch all job details
        var jobGroups = await scheduler.GetJobGroupNames();
        var triggerGroups = await scheduler.GetTriggerGroupNames();

        List<JobDetails> jobDetailsList = new List<JobDetails>();

        foreach (var group in jobGroups)
        {
            var jobKeys = await scheduler.GetJobKeys(Quartz.Impl.Matchers.GroupMatcher<JobKey>.GroupEquals(group));
            foreach (var jobKey in jobKeys)
            {
                var detail = await scheduler.GetJobDetail(jobKey);
                var triggers = await scheduler.GetTriggersOfJob(jobKey);
                foreach (var trigger in triggers)
                {
                    jobDetailsList.Add(new JobDetails
                    {
                        JobName = jobKey.Name,
                        JobGroup = jobKey.Group,
                        TriggerName = trigger.Key.Name,
                        TriggerGroup = trigger.Key.Group,
                        TriggerState = await scheduler.GetTriggerState(trigger.Key),
                        NextFireTime = trigger.GetNextFireTimeUtc()?.LocalDateTime.ToString()
                    });
                }
            }
        }

        // Display job details in a tabular format
        Console.WriteLine($"{"Job Name",-20} {"Job Group",-20} {"Trigger Name",-20} {"Trigger Group",-20} {"Trigger State",-20} {"Next Fire Time",-20}");
        foreach (var jobDetail in jobDetailsList)
        {
            Console.WriteLine($"{jobDetail.JobName,-20} {jobDetail.JobGroup,-20} {jobDetail.TriggerName,-20} {jobDetail.TriggerGroup,-20} {jobDetail.TriggerState,-20} {jobDetail.NextFireTime,-20}");
        }
    }
}

class JobDetails
{
    public string JobName { get; set; }
    public string JobGroup { get; set; }
    public string TriggerName { get; set; }
    public string TriggerGroup { get; set; }
    public TriggerState TriggerState { get; set; }
    public string NextFireTime { get; set; }
}
