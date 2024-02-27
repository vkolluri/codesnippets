using Quartz;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IniParser; // Use an INI file parser library
using IniParser.Model;

public class FileScanJob : IJob
{
    public async Task Execute(IJobExecutionContext context)
    {
        var scheduler = context.Scheduler;
        var fileParser = new FileIniDataParser();
        IniData data = fileParser.ReadFile("path/to/your/config.ini");

        foreach (var section in data.Sections)
        {
            string jobName = section.SectionName;
            string jobType = section.Keys["Type"];
            string cronExpression = section.Keys["CronExpression"];

            var jobKey = new JobKey(jobName);
            var jobDetail = JobBuilder.Create(Type.GetType(jobType))
                                      .WithIdentity(jobKey)
                                      .Build();

            var trigger = TriggerBuilder.Create()
                                        .WithIdentity($"{jobName}-trigger")
                                        .WithCronSchedule(cronExpression)
                                        .Build();

            // Check if the job already exists
            if (await scheduler.CheckExists(jobKey))
            {
                // Reschedule the job with the new trigger
                await scheduler.RescheduleJob(new TriggerKey($"{jobName}-trigger"), trigger);
            }
            else
            {
                // Schedule the new job with its trigger
                await scheduler.ScheduleJob(jobDetail, trigger);
            }
        }
    }
}

IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler();
await scheduler.Start();

IJobDetail fileScanJob = JobBuilder.Create<FileScanJob>()
    .WithIdentity("FileScanJob", "group1")
    .Build();

ITrigger trigger = TriggerBuilder.Create()
    .WithIdentity("FileScanJobTrigger", "group1")
    .StartNow()
    .WithSimpleSchedule(x => x
        .WithIntervalInMinutes(10) // Scan every 10 minutes
        .RepeatForever())
    .Build();

await scheduler.ScheduleJob(fileScanJob, trigger);
