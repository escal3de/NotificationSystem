namespace NotificationSystem;

public interface INotificationFactory
{
    INotificationService Create(NotificationType notificationType);
}