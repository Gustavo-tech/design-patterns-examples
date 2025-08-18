using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Services;
internal static class CryptoFactory
{
    internal static CryptoService GetCryptoService(string currency)
    {
        return currency switch
        {
            "BTC" => new BitcoinService(),
            "ETH" => new EthereumService(),
            _ => throw new NotSupportedException($"Currency {currency} is not supported")
        };
    }
}
