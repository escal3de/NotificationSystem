namespace NotificationSystem;

public class UserNotifier
{
    private readonly INotificationFactory _notificationFactory;
    private readonly ILogger _logger;
    private readonly IMangodb _mangodb;

    public UserNotifier(INotificationFactory notificationFactory, ILogger logger, IMangodb mangodb)
    {
        _notificationFactory = notificationFactory;
        _logger = logger;
        _mangodb = mangodb;
    }

    public void NotifyUser(NotificationType notificationType, string user, string message)
    {
        _notificationFactory
            .Create(notificationType)
            .Send(user, message);
        _logger.LogMessage("Message sent");
        _mangodb.Add($"{notificationType}, {user},  {message}: successful added in my mangomango db");
    }
}