namespace NotificationSystem.Services;

public class SmsNotificationService : INotificationService
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"SMS to {recipient}: {message}");
    }
}