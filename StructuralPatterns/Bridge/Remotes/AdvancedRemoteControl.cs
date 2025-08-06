using Bridge.Devices;

namespace Bridge.Remotes;

internal class AdvancedRemoteControl : RemoteControl
{
    internal AdvancedRemoteControl(IDevice device) 
        : base(device)
    {
    }

    internal void Mute()
    {
        _device.Volume = 0;
    }
}
