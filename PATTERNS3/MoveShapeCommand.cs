class MoveShapeCommand : ICommand
{
    private Shape _shape;
    private int _newX;
    private int _newY;

    public MoveShapeCommand(Shape shape, int newX, int newY)
    {
        _shape = shape;
        _newX = newX;
        _newY = newY;
    }

    public void Execute()
    {
        _shape.X = _newX;
        _shape.Y = _newY;
        Console.WriteLine($"Фигура {_shape.Type} перемещена на координаты ({_newX}, {_newY})");
    }
}