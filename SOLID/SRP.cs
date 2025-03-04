namespace SingalRisponsibility
{

    public class Order
    {
        public int OrderId { get; set; }
    }
    public class OrderProcessing
    {
        public void Process(Order order)
        {
            Console.WriteLine($"Order Processed : {order.OrderId}");
        }
    }
    public class Payment
    {
        public void ProcessPayment(Order order)
        {
            Console.WriteLine($"Payment Processed : {order.OrderId}");
        }
    }

    public class Notification
    {
        public void SendEmail()
        {
            Console.WriteLine("Email Sent");
        }
    }

}


