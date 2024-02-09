<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <add key="SmtpHost" value="smtp.example.com"/>
    <add key="SmtpPort" value="587"/>
    <add key="FromAddress" value="your-email@example.com"/>
    <add key="ToAddress" value="recipient-email@example.com"/>
    <add key="SmtpUsername" value="your-smtp-username"/>
    <add key="SmtpPassword" value="your-smtp-password"/>
  </appSettings>
</configuration>

using System.Threading.Tasks;

public class EmailNotificationJobListener : JobListenerSupport
{
    private readonly string _smtpHost = ConfigurationManager.AppSettings["SmtpHost"];
    private readonly int _smtpPort = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
    private readonly string _fromAddress = ConfigurationManager.AppSettings["FromAddress"];
    private readonly string _toAddress = ConfigurationManager.AppSettings["ToAddress"];
    private readonly string _smtpUsername = ConfigurationManager.AppSettings["SmtpUsername"];
    private readonly string _smtpPassword = ConfigurationManager.AppSettings["SmtpPassword"];


    public EmailNotificationJobListener(string smtpHost, int smtpPort, string fromAddress, string toAddress, string smtpUsername, string smtpPassword)
    {
        _smtpHost = smtpHost;
        _smtpPort = smtpPort;
        _fromAddress = fromAddress;
        _toAddress = toAddress;
        _smtpUsername = smtpUsername;
        _smtpPassword = smtpPassword;
    }

    public override string Name => "EmailNotificationJobListener";

    public override Task JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException, CancellationToken cancellationToken = default)
    {
        if (jobException != null)
        {
            SendErrorEmail(context, jobException);
        }

        return Task.CompletedTask;
    }

    private void SendErrorEmail(IJobExecutionContext context, JobExecutionException jobException)
    {
        try
        {
            using (var smtpClient = new SmtpClient(_smtpHost, _smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(_smtpUsername, _smtpPassword);
                smtpClient.EnableSsl = true;

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(_fromAddress),
                    Subject = $"Job Error Notification: {context.JobDetail.Key}",
                    Body = $"An error occurred in job {context.JobDetail.Key}: {jobException.Message}",
                    IsBodyHtml = false
                };
                mailMessage.To.Add(_toAddress);

                smtpClient.Send(mailMessage);
            }
        }
        catch (Exception ex)
        {
            // Handle any errors that occurred during sending email
            Console.WriteLine($"Failed to send error email: {ex.Message}");
        }
    }
}

scheduler.ListenerManager.AddJobListener(emailNotificationListener, EverythingMatcher<JobKey>.AllJobs());
