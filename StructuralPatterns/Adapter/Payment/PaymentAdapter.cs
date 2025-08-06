using Adapter.Payment.Abstractions;

namespace Adapter.Payment;

internal class PaymentAdapter : IPaymentProcessor
{
    private readonly OldPaymentSystem _oldPaymentSystem;

    internal PaymentAdapter(OldPaymentSystem oldPaymentSystem)
    {
        _oldPaymentSystem = oldPaymentSystem ?? throw new ArgumentNullException(nameof(oldPaymentSystem));
    }

    public void ProcessPayment(string accountNumber, decimal amount)
    {
        double valueAdapted = (double) amount;
        _oldPaymentSystem.MakePayment(accountNumber, valueAdapted);
    }
}
