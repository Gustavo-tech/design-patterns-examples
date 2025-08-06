namespace Singleton;

internal class AppConfiguration
{
    internal string ServerToConnect { get; set; }
    private static AppConfiguration? _instance;

    private AppConfiguration()
    {
        ServerToConnect = "https://api.example.com";
    }

    internal static AppConfiguration GetInstance()
    {
        _instance ??= new AppConfiguration();
        return _instance;
    }
}
