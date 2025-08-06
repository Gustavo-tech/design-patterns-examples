using Bridge.Devices;
using Bridge.Remotes;

Tv tv = new();
RemoteControl remote = new(tv);
remote.TogglePower();

Console.WriteLine($"TV is enabled: {tv.IsEnabled}");

Radio radio = new();
AdvancedRemoteControl advancedRemote = new(radio);
advancedRemote.TogglePower();
advancedRemote.Mute();

Console.WriteLine($"Radio is enabled: {radio.IsEnabled}");