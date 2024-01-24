 <quartz>

    <add key="quartz.plugin.recentHistory.type" value="Quartz.Plugins.RecentHistory.ExecutionHistoryPlugin, Quartz.Plugins.RecentHistory" />
    <add key="quartz.plugin.recentHistory.storeType" value="Quartz.Plugins.RecentHistory.Impl.InProcExecutionHistoryStore, Quartz.Plugins.RecentHistory" />
    <add key="quartz.serializer.type" value="json" />
    <add key="quartz.threadPool.type" value="Quartz.Simpl.SimpleThreadPool, Quartz" />
    <add key="quartz.threadPool.threadCount" value="10" />
    <add key="quartz.jobStore.type" value="Quartz.Impl.AdoJobStore.JobStoreTX, Quartz" />
    <add key="quartz.jobStore.misfireThreshold" value="60000" />
    <add key="quartz.jobStore.dataSource" value="default" />
    <add key="quartz.jobStore.tablePrefix" value="qrtz_" />
    <add key="quartz.jobStore.driverDelegateType" value="Quartz.Impl.AdoJobStore.SQLiteDelegate, Quartz" />
    <add key="quartz.dataSource.default.provider" value="SQLite" />
    <add key="quartz.dataSource.default.connectionString" value="Data Source=E:\WebApplication1\App_Data\quartznet.db;Version=3;" />
  </quartz>

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var scheduler = Quartz.Impl.StdSchedulerFactory.GetDefaultScheduler().Result;



            scheduler.Start();


            app.UseQuartzmin(new QuartzminOptions()
            {
                Scheduler = scheduler,

            });
        }
    }
