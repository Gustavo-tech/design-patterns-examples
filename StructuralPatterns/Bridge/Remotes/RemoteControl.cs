using Bridge.Devices;

namespace Bridge.Remotes;

internal class RemoteControl
{
    protected IDevice _device;

    internal RemoteControl(IDevice device)
    {
        _device = device ?? throw new ArgumentNullException(nameof(device));
    }

    internal void TogglePower()
    {
        if (!_device.IsEnabled)
            _device.IsEnabled = true;

        else
            _device.IsEnabled = false;
    }

    internal void VolumeUp()
    {
        _device.Volume += 1;
    }

    internal void VolumeDown()
    {
        _device.Volume -= 1;
    }

    internal void ChannelUp()
    {
        _device.Channel += 1;
    }

    internal void ChannelDown()
    {
        _device.Channel -= 1;
    }
}
