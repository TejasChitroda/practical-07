interface IShape {
    int GetArea();
}

class Ractangle : IShape {
    public int Width {get; set;}
    public int Height {get; set;}

    public int GetArea() {
        return Width * Height;
    }
}

class Square : IShape {
    public int Side {get; set;}

    public int GetArea()
    {
        return Side * Side;
    }
}