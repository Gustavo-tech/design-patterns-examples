namespace Facade.Services;

internal class UIService
{
    internal static string GetLoggedInUserId()
    {
        return "12345";
    }

    internal void Login(string username, string password)
    {
        // Simulate login logic
        Console.WriteLine($"User {username} logged in successfully.");
    }

    internal void Logout()
    {
        // Simulate logout logic
        Console.WriteLine("User logged out successfully.");
    }
}
