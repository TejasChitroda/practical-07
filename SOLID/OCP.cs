

interface IPaymentMethod {
    void ProcessPayment();
}

class CreditCardPayment : IPaymentMethod {
    public void ProcessPayment() {
        Console.WriteLine($"Payment procced using Creadit card");
    }
}
class PayPalPayment : IPaymentMethod
{
    public void ProcessPayment() {
        Console.WriteLine($"PayPal Payment Processed");
    }
}

class Cash : IPaymentMethod {
    
    public void ProcessPayment()
    {
       Console.WriteLine("Cash Payment processed");
    }
}

class PaymentProcessor {
    public void ProccessPayment(IPaymentMethod paymentMethod) {
        paymentMethod.ProcessPayment();
    }
}