// Define an interface IShape that enforces the implementation of the GetArea method.
interface IShape 
{
    int GetArea(); // Method to calculate the area of a shape.
}

// Rectangle class implementing IShape
class Rectangle : IShape 
{
    // Properties for width and height of the rectangle
    public int Width { get; set; }
    public int Height { get; set; }

    // Method to calculate the area of the rectangle
    public int GetArea() 
    {
        return Width * Height;
    }
}

// Square class implementing IShape
class Square : IShape 
{
    // Property for the side length of the square
    public int Side { get; set; }

    // Method to calculate the area of the square
    public int GetArea()
    {
        return Side * Side;
    }
}
