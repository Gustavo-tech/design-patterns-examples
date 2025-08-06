namespace Bridge.Devices;

internal class Tv : IDevice
{
    public int Volume { get; set; }
    public bool IsEnabled { get; set; }
    public int Channel { get; set; }

    public Tv()
    {
        Volume = 10;
        IsEnabled = false;
        Channel = 1;
    }
}
