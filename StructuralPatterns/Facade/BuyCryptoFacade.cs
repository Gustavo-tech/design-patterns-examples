using Facade.Models;
using Facade.Services;

namespace Facade;
internal class BuyCryptoFacade
{
    internal void BuyCryptoCurrency(double amount, string currency)
    {
        DatabaseService dbService = new DatabaseService();
        User user = dbService.GetUser(UIService.GetLoggedInUserId());
        if (user.Balance < amount)
        {
            Console.WriteLine($"Insufficient balance. You have {user.Balance} {user.Currency}.");
            return;
        }

        CryptoFactory.GetCryptoService(currency).BuyCurrency(user, amount);
        MailService mailService = new();
        mailService.SendEmail(user);
        Console.WriteLine("Crypto bought successfulyy");
    }
}
