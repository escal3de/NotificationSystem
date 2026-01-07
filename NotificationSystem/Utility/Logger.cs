namespace NotificationSystem.Utility;

public class Logger : ILogger
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}