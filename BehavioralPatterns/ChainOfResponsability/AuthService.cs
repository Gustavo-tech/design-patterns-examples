using ChainOfResponsability.Handlers;

namespace ChainOfResponsability;
internal class AuthService(Database database)
{
    private readonly Database _database = database ?? throw new ArgumentNullException(nameof(database));

    public bool Login(string username, string password)
    {
        UserExistsHandler handler = new(_database);
        ValidPasswordHandler validPasswordHandler = new(_database);
        RoleCheckedHandler roleCheckedHandler = new();

        handler.SetNext(validPasswordHandler);
        validPasswordHandler.SetNext(roleCheckedHandler);

        return handler.Handle(username, password);
    }
}
