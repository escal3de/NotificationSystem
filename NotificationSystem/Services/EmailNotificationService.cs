namespace NotificationSystem.Services;

public class EmailNotificationService : INotificationService
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"Email to {recipient}: {message}");
    }
}