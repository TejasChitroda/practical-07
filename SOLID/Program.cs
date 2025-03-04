using SingalRisponsibility;

class Program {
    public static void Main(string[] args) 
    {
        Order or = new Order();
        or.OrderId = 5;

        OrderProcessing op = new OrderProcessing();
        op.Process(or);

        Payment p = new Payment();
        p.ProcessPayment(or);

        Notification notifi = new Notification();
        notifi.SendEmail();


        PaymentProcessor processor = new PaymentProcessor();

        IPaymentMethod creaditCard = new CreditCardPayment();
        processor.ProccessPayment(creaditCard);

        IPaymentMethod paypal = new PayPalPayment();
        processor.ProccessPayment(paypal);

        IPaymentMethod cash = new Cash();
        processor.ProccessPayment(cash);



        IShape ract = new Ractangle() {Width = 20 , Height = 30};
        Console.WriteLine($"Ractangle area : {ract.GetArea()}");

        IShape square = new Square() {Side = 20};
        Console.WriteLine($"Ractangle area : {square.GetArea()}");


        IPrint basicPrinter = new BasicPrinter();
        basicPrinter.Print();

        IScan scan = new Scanner();
        scan.Scan();

        MultiFunctionPrinter multi = new MultiFunctionPrinter();
        multi.Print();
        multi.Scan();
        multi.Fax();


        // Using Petrol Engine
        IEngine petrolEngine = new PetrolEngine();
        Vehical car1 = new Vehical(petrolEngine);
        car1.Start("Starting journey with Petrol Engine!");

        Console.WriteLine();

        // Using Diesel Engine
        IEngine dieselEngine = new DieselEngine();
        Vehical car2 = new Vehical(dieselEngine);
        car2.Start("Diesel Engine is now running!");

        Console.WriteLine();

        // Using Electric Engine
        IEngine electricEngine = new ElectricEngine();
        Vehical car3 = new Vehical(electricEngine);
        car3.Start("Going green with an Electric Engine!");

    }
}