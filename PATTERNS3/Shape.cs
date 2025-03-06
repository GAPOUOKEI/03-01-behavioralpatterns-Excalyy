class Shape
{
    public string Type { get; set; } // Тип фигуры (круг, квадрат)
    public int X { get; set; } // Координата X
    public int Y { get; set; } // Координата Y

    public Shape(string type, int x, int y)
    {
        Type = type;
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"{Type} на координатах ({X}, {Y})");
    }
}
