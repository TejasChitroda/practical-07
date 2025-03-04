interface IEngine {
    void Start(string engine);
   
}
class PetrolEngine : IEngine {
    public void Start(string engine) 
    {
        Console.WriteLine($"This is {engine} engine");
    }
}
class DieselEngine : IEngine {
    public void Start(string engine) 
    {
        Console.WriteLine($"This is {engine} engine");
    }
}
class ElectricEngine : IEngine {
    public void Start(string engine) 
    {
        Console.WriteLine($"This is {engine} engine");
    }
}


class Vehical {
    private readonly IEngine _engine;

    public Vehical(IEngine engine) {
        _engine = engine;
    }

    public void Start(string engine) {
        _engine.Start(engine); // Calls the appropriate engine type
        Console.WriteLine("Vehicle is running");
    }
}