namespace NotificationSystem;

public interface INotificationService
{
    void Send(string recipient, string message);
}