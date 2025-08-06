namespace Adapter.Payment.Abstractions;

internal interface IPaymentProcessor
{
    void ProcessPayment(string accountNumber, decimal amount);
}
