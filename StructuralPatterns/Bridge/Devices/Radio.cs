namespace Bridge.Devices;

internal class Radio : IDevice
{
    public int Volume { get; set; }
    public bool IsEnabled { get; set; }
    public int Channel { get; set; }

    public Radio()
    {
        Volume = 10;
        IsEnabled = false;
        Channel = 1;
    }
}
