namespace NotificationSystem.Interfaces;

public interface INotificationFactory
{
    INotificationService Create(NotificationType notificationType);
}