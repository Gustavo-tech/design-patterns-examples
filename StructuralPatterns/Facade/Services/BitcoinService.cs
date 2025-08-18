using Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Services;
internal class BitcoinService : CryptoService
{
    internal override void BuyCurrency(User user, double amount)
    {
        Console.WriteLine($"Buying {amount} of Bitcoin");
    }
}
