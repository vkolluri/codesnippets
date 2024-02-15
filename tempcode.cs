using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

public class FileWatcherConfig
{
    public string DirectoryPath { get; set; }
    public List<string> Filters { get; set; }
    public string StoredProcedure { get; set; }
}

public class IniConfigurationReader
{
    public IConfigurationRoot Configuration { get; set; }

    public IniConfigurationReader(string filePath)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddIniFile(filePath);

        Configuration = builder.Build();
    }

    public IEnumerable<FileWatcherConfig> ReadConfigurations()
    {
        var configs = new List<FileWatcherConfig>();
        
        foreach (var section in Configuration.GetChildren())
        {
            var config = new FileWatcherConfig
            {
                DirectoryPath = section["DirectoryPath"],
                Filters = new List<string>(section["Filters"].Split(',')),
                StoredProcedure = section["StoredProcedure"]
            };
            
            configs.Add(config);
        }

        return configs;
    }
}
------

public void SetupFileWatchers(IEnumerable<FileWatcherConfig> configs)
{
    foreach (var config in configs)
    {
        var watcher = new FileSystemWatcher(config.DirectoryPath)
        {
            IncludeSubdirectories = true,
            NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite,
        };

        foreach (var filter in config.Filters)
        {
            // Note: FileSystemWatcher supports setting one filter at a time.
            // You might need separate watchers for each filter or handle it differently.
            watcher.Filter = filter;
            watcher.Created += (sender, e) =>
            {
                // Schedule Quartz.NET job to process the file and execute the stored procedure
            };

            watcher.EnableRaisingEvents = true;
        }
    }
}
=----------

  public class DirectoryMonitoringSetupJob : IJob
{
    public async Task Execute(IJobExecutionContext context)
    {
        // Path to your INI configuration file
        string iniFilePath = "path/to/your/fileWatcherConfig.ini";

        // Create the configuration reader and read configurations
        var configurationReader = new IniConfigurationReader(iniFilePath);
        var configs = configurationReader.ReadConfigurations();

        // Setup file watchers based on the read configurations
        SetupFileWatchers(configs, context.Scheduler);
    }

    private void SetupFileWatchers(IEnumerable<FileWatcherConfig> configs, IScheduler scheduler)
    {
        foreach (var config in configs)
        {
            var watcher = new FileSystemWatcher(config.DirectoryPath)
            {
                IncludeSubdirectories = true,
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite,
            };

            watcher.Created += async (sender, e) =>
            {
                // Schedule a Quartz.NET job to process the created file
                // Similar to previous examples, but use `scheduler` to schedule the job
            };

            watcher.EnableRaisingEvents = true;
        }
    }
}
-------
[Watcher1]
DirectoryPath=/source/dir1
Filters=*.txt,*.csv
StoredProcedure=sp_DataLoad_Dir1

[Watcher2]
DirectoryPath=/source/dir2
Filters=*.pdf,*.xlsx
StoredProcedure=sp_DataLoad_Dir2
