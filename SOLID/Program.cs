using SingalRisponsibility;


class Program {
    public static void Main(string[] args) 
    {
        // Singal responsibility Principle
        Console.WriteLine("\nSingal responsibility Principle\n");
        Order or = new Order();
        or.OrderId = 5;

        OrderProcessing op = new OrderProcessing();
        op.Process(or);

        Payment p = new Payment();
        p.ProcessPayment(or);

        Notification notifi = new Notification();
        notifi.SendEmail();

        // Open Closed Principel
        Console.WriteLine("\nOpen Closed Principle\n");

        PaymentProcessor processor = new PaymentProcessor();

        IPaymentMethod creaditCard = new CreditCardPayment();
        processor.ProcessPayment(creaditCard);

        IPaymentMethod paypal = new PayPalPayment();
        processor.ProcessPayment(paypal);

        IPaymentMethod cash = new Cash();
        processor.ProcessPayment(cash);



        //Liskov substitution principle
        Console.WriteLine("\nLiskov substitution Principle\n");

        IShape ract = new Rectangle() {Width = 20 , Height = 30};
        Console.WriteLine($"Ractangle area : {ract.GetArea()}");

        IShape square = new Square() {Side = 20};
        Console.WriteLine($"Ractangle area : {square.GetArea()}");


        // Interface Segregation Principle
        Console.WriteLine("\nInterface Segregation Principle\n");
        IPrint basicPrinter = new BasicPrinter();
        basicPrinter.Print();

        IScan scan = new Scanner();
        scan.Scan();

        MultiFunctionPrinter multi = new MultiFunctionPrinter();
        multi.Print();
        multi.Scan();
        multi.Fax();



        //  Dependency Inversion Principle
        Console.WriteLine("\nDependency Inversion Principle\n");
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