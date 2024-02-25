public string ToCronExpression(string scheduleDays, string scheduleTime)
{
    // Assuming scheduleTime is in HHmm format
    var hour = int.Parse(scheduleTime.Substring(0, 2));
    var minute = int.Parse(scheduleTime.Substring(2, 2));

    // Handle the every day (*) case
    if (scheduleDays == "*")
    {
        return $"{minute} {hour} ? * *";
    }

    // Convert days to cron day-of-week values for specific days
    var daysOfWeek = scheduleDays.Split(',');
    var cronDaysOfWeek = daysOfWeek.Select(day => day switch
    {
        "SU" => "1",
        "MO" => "2",
        "TU" => "3",
        "WE" => "4",
        "TH" => "5",
        "FR" => "6",
        "SA" => "7",
        _ => throw new ArgumentException($"Invalid day: {day}")
    });

    // Build the cron expression for specific days
    return $"{minute} {hour} ? * {string.Join(",", cronDaysOfWeek)}";
}
