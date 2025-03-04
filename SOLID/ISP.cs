// Separate interfaces based on printer capabilities
interface IPrint
{
    void Print();
}

interface IScan
{
    void Scan();
}

interface IFax
{
    void Fax();
}

// A basic printer only implements the Print interface
class BasicPrinter : IPrint
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }
}

// A scanner implements only the Scan interface
class Scanner : IScan
{
    public void Scan() { Console.WriteLine("Scanning..."); }
}

// A multifunction printer implements all required interfaces
class MultiFunctionPrinter : IPrint, IScan, IFax
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }
    public void Scan() 
    { 
        Console.WriteLine("Scanning..."); 
    }
    public void Fax() 
    { 
        Console.WriteLine("Faxing..."); 
    }
}

