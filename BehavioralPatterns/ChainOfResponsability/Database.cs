namespace ChainOfResponsability;

internal class Database
{
    private Dictionary<string, string> _users;

    internal Database()
    {
        _users = new Dictionary<string, string>
        {
            { "admin_username", "admin_password" },
            { "user_username", "user_password" }
        };
    }

    internal bool IsValidUser(string username) => _users.ContainsKey(username);

    internal bool IsValidPassword(string username, string password) => _users[username].Equals(password);
}
