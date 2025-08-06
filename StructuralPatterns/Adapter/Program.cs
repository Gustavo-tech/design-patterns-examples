using Adapter.Payment;

OldPaymentSystem oldPaymentSystem = new();
PaymentAdapter paymentAdapter = new(oldPaymentSystem);
ECommersePlatform eCommersePlatform = new(paymentAdapter);

eCommersePlatform.Checkout("1234-5678-9012-3456", 250.75m);