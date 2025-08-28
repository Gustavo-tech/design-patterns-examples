namespace ChainOfResponsability.Handlers;

internal class UserExistsHandler : BaseHandler
{
    private Database _database;

    internal UserExistsHandler(Database database)
    {
        _database = database;
    }

    internal override bool Handle(string username, string password)
    {
        if (!_database.IsValidUser(username))
        {
            Console.WriteLine("Invalid credentials");
            return false;
        }

        return HandleNext(username, password);
    }
}
