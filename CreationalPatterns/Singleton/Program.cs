using Singleton;

AppConfiguration config = AppConfiguration.GetInstance();
AppConfiguration config2 = AppConfiguration.GetInstance();

Console.WriteLine("Before the change");
Console.WriteLine(config.ServerToConnect);
Console.WriteLine(config2.ServerToConnect);
Console.WriteLine();

config.ServerToConnect = "https://api.changed.com";

Console.WriteLine("After the change");

Console.WriteLine(config.ServerToConnect);
Console.WriteLine(config2.ServerToConnect);