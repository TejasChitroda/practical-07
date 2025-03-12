// Define an interface IEngine that abstracts engine behavior
// This follows the Dependency Inversion Principle (DIP) by depending on an abstraction, not a concrete implementation.
interface IEngine 
{
    void Start(string engine); // Method to start an engine
}

// PetrolEngine class implements IEngine
class PetrolEngine : IEngine 
{
    public void Start(string engine) 
    {
        // Starts a petrol engine
        Console.WriteLine($"This is {engine} engine");
    }
}

// DieselEngine class implements IEngine
class DieselEngine : IEngine 
{
    public void Start(string engine) 
    {
        // Starts a diesel engine
        Console.WriteLine($"This is {engine} engine");
    }
}

// ElectricEngine class implements IEngine
class ElectricEngine : IEngine 
{
    public void Start(string engine) 
    {
        // Starts an electric engine
        Console.WriteLine($"This is {engine} engine");
    }
}

// Vehicle class depends on the abstraction (IEngine) rather than concrete engine implementations
// This follows DIP by injecting the engine dependency via constructor
class Vehical 
{
    private readonly IEngine _engine; // Dependency injection of an engine

    public Vehical(IEngine engine) 
    {
        _engine = engine; // Assigning injected engine to the private field
    }

    public void Start(string engine) 
    {
        _engine.Start(engine); // Calls the appropriate engine type dynamically
        Console.WriteLine("Vehicle is running");
    }
}
