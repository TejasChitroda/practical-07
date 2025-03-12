// Define an interface that enforces a common behavior for all payment methods
// This follows the Open/Closed Principle (OCP) because new payment methods 
// can be added without modifying existing code.
interface IPaymentMethod 
{
    void ProcessPayment(); // Each payment method must implement this method.
}

// CreditCardPayment class implements IPaymentMethod
class CreditCardPayment : IPaymentMethod 
{
    public void ProcessPayment() 
    {
        // Process payment using a credit card
        Console.WriteLine("Payment processed using Credit Card");
    }
}

// PayPalPayment class implements IPaymentMethod
class PayPalPayment : IPaymentMethod 
{
    public void ProcessPayment() 
    {
        // Process payment using PayPal
        Console.WriteLine("PayPal Payment Processed");
    }
}

// Cash class implements IPaymentMethod
class Cash : IPaymentMethod 
{
    public void ProcessPayment() 
    {
        // Process payment using cash
        Console.WriteLine("Cash Payment Processed");
    }
}

// PaymentProcessor class handles payments without depending on specific payment methods
// This class follows OCP because it doesn't need modification when new payment types are added.
class PaymentProcessor 
{
    public void ProcessPayment(IPaymentMethod paymentMethod) 
    {
        // Calls the appropriate payment processing method dynamically
        paymentMethod.ProcessPayment();
    }
}