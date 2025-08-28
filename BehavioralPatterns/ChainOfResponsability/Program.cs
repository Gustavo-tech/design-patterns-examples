using ChainOfResponsability;

Database database = new();
AuthService authService = new(database);

bool isValid = authService.Login("user", "admin_password");
Console.WriteLine(isValid);

isValid = authService.Login("admin_username", "password");
Console.WriteLine(isValid);

isValid = authService.Login("admin_username", "admin_password");
Console.WriteLine(isValid);

isValid = authService.Login("user_username", "user_password");
Console.WriteLine(isValid);