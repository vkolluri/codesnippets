<?xml version="1.0" encoding="utf-8" ?>
<log4net>
    <!-- Appender for DEBUG messages -->
    <appender name="DebugAppender" type="log4net.Appender.RollingFileAppender">
        <file value="logs/debug.log" />
        <appendToFile value="true" />
        <rollingStyle value="Size" />
        <maxSizeRollBackups value="5" />
        <maximumFileSize value="10MB" />
        <staticLogFileName value="true" />
        <layout type="log4net.Layout.PatternLayout">
            <conversionPattern value="%date [%thread] %-5level %logger - %message%newline" />
        </layout>
        <filter type="log4net.Filter.LevelRangeFilter">
            <levelMin value="DEBUG" />
            <levelMax value="DEBUG" />
        </filter>
    </appender>

    <!-- Appender for INFO, WARN, ERROR, and FATAL messages -->
    <appender name="InfoAppender" type="log4net.Appender.RollingFileAppender">
        <file value="logs/info.log" />
        <appendToFile value="true" />
        <rollingStyle value="Size" />
        <maxSizeRollBackups value="5" />
        <maximumFileSize value="10MB" />
        <staticLogFileName value="true" />
        <layout type="log4net.Layout.PatternLayout">
            <conversionPattern value="%date [%thread] %-5level %logger - %message%newline" />
        </layout>
        <filter type="log4net.Filter.LevelRangeFilter">
            <levelMin value="INFO" />
            <levelMax value="FATAL" />
        </filter>
    </appender>

    <!-- Root logger setup -->
    <root>
        <level value="DEBUG" />
        <appender-ref ref="DebugAppender" />
        <appender-ref ref="InfoAppender" />
    </root>
</log4net>
