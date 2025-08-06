namespace Adapter.Payment;

internal class OldPaymentSystem
{
    internal void MakePayment(string cardNumber, double amount)
    {
        Console.WriteLine($"Processing payment of {amount} using card {cardNumber} via the old system.");
    }
}
