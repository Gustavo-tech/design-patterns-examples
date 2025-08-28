namespace ChainOfResponsability.Handlers;

internal class RoleCheckedHandler : BaseHandler
{
    internal override bool Handle(string username, string password)
    {
        if (username == "admin_username")
        {
            Console.WriteLine("Admin user");
            return true;
        }

        Console.WriteLine("Normal user");
        return HandleNext(username, password);
    }
}
