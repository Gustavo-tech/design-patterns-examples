using Facade.Models;

namespace Facade.Services;
internal class DatabaseService
{
    internal User GetUser(string userId)
    {
        // Simulate fetching user from a database
        return new User(userId, "John Doe", 1000.0, "USD", 123456);
    }
}
