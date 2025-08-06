namespace Bridge.Devices;

internal interface IDevice
{
    internal int Volume { get; set; }
    internal bool IsEnabled { get; set; }
    internal int Channel { get; set; }
}
