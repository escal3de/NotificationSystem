namespace NotificationSystem;

public class Mangodb : IMangodb
{
    private readonly ILogger _logger;

    public Mangodb(ILogger logger)
    {
        _logger = logger;
    }
    
    public void Add(string data)
    {
        _logger.LogMessage(data);
    }
}