namespace Proxy;

internal class ProxyInternet : IInternet
{
    private RealInternet _realInternet = new RealInternet();
    private List<string> _bannedSites = ["abc.com", "xyz.com", "banned.com"];

    public void ConnectTo(string serverhost)
    {
        if (_bannedSites.Contains(serverhost.ToLower()))
        {
            Console.WriteLine("Access Denied to " + serverhost);
        }
        else
        {
            _realInternet.ConnectTo(serverhost);
        }
    }
}
