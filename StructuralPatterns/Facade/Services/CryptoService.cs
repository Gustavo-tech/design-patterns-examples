using Facade.Models;

namespace Facade.Services;
internal abstract class CryptoService
{
    internal abstract void BuyCurrency(User user, double amount);
}
