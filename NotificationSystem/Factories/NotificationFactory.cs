using Microsoft.Extensions.DependencyInjection;

namespace NotificationSystem;

public class NotificationFactory : INotificationFactory
{
    private readonly IServiceProvider _serviceProvider;

    public NotificationFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    private readonly Dictionary<NotificationType, Type> _map = new Dictionary<NotificationType, Type>()
    {
        { NotificationType.Email, typeof(EmailNotificationService) },
        { NotificationType.Sms, typeof(SmsNotificationService) }
    };

    public INotificationService Create(NotificationType notificationType)
    {
        if (!_map.ContainsKey(notificationType))
        {
            throw new ArgumentOutOfRangeException(nameof(notificationType));
        }

        return (INotificationService)_serviceProvider.GetRequiredService(_map[notificationType]);
    }
}