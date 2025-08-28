namespace ChainOfResponsability.Handlers;

internal class ValidPasswordHandler : BaseHandler
{
    private readonly Database _database;

    internal ValidPasswordHandler(Database database)
    {
        _database = database;
    }

    internal override bool Handle(string username, string password)
    {
        if (!_database.IsValidPassword(username, password))
        {
            Console.WriteLine("Invalid credentials");
            return false;
        }

        return HandleNext(username, password);
    }
}
