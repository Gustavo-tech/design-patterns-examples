using Adapter.Payment.Abstractions;

namespace Adapter.Payment;

internal class ECommersePlatform
{
    private readonly IPaymentProcessor _paymentProcessor;

    internal ECommersePlatform(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor ?? throw new ArgumentNullException(nameof(paymentProcessor));
    }

    internal void Checkout(string accountNumber, decimal amount)
    {
        Console.WriteLine("Initiating checkout process...");
        _paymentProcessor.ProcessPayment(accountNumber, amount);
        Console.WriteLine("Checkout completed successfully.");
    }
}
