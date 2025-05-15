namespace SimpleRPGClient.Core.Configuration;

public class AppConfiguration
{
    public string ServerUrl { get; private set; } = string.Empty;
    public static AppConfiguration Default()
    {
        return new AppConfiguration()
        {
            ServerUrl = "http://localhost:7163",
        };
    }
}
