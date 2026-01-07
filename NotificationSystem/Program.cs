namespace NotificationSystem;

public class Program
{
    public static void Main(string[] args)
    {
        string user = Console.ReadLine()?.Trim() ?? string.Empty;
        string message = Console.ReadLine()?.Trim() ?? string.Empty;
        if (!Enum.TryParse(Console.ReadLine() ?? "Email", out NotificationType result))
        {
            Console.WriteLine("Bad type");
            result = NotificationType.Email;
        }

        var serviceCollection = new ServiceCollection();

        serviceCollection
            .AddTransient<UserNotifier>()
            .AddTransient<ILogger, Logger>()
            .AddTransient<IMangodb, Mangodb>()
            .AddTransient<EmailNotificationService>()
            .AddTransient<SmsNotificationService>()
            .AddSingleton<INotificationFactory, NotificationFactory>();


        var serviceProvider = serviceCollection.BuildServiceProvider();

        var userNotifier = serviceProvider.GetRequiredService<UserNotifier>();

        if (!string.IsNullOrWhiteSpace(user)) userNotifier.NotifyUser(result, user, message);

        else Console.WriteLine("User not found");
    }
}