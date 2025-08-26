namespace Proxy;

internal class RealInternet : IInternet
{
    public void ConnectTo(string serverhost)
    {
        Console.WriteLine("Connecting to " + serverhost);
    }
}
