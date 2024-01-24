<?xml version="1.0" encoding="utf-8"?>
<configuration>
	<configSections>
		<section name="quartz" type="System.Configuration.NameValueSectionHandler, System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
	</configSections>
	<startup>
		<supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
	</startup>
	<quartz>
		<add key="quartz.scheduler.instanceName" value="MyScheduler" />
		<add key="quartz.threadPool.type" value="Quartz.Simpl.SimpleThreadPool, Quartz" />
		<add key="quartz.threadPool.threadCount" value="10" />
		<add key="quartz.jobStore.misfireThreshold" value="60000" />
		
	</quartz>
	
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <assemblyIdentity name="Newtonsoft.Json" publicKeyToken="30ad4fe6b2a6aeed" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-13.0.0.0" newVersion="13.0.0.0" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="Quartz" publicKeyToken="f6b8c98a402cc8a4" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-3.8.0.0" newVersion="3.8.0.0" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="System.Memory" publicKeyToken="cc7b13ffcd2ddd51" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-4.0.1.1" newVersion="4.0.1.1" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="Microsoft.Owin" publicKeyToken="31bf3856ad364e35" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-2.1.0.0" newVersion="2.1.0.0" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>
</configuration>
