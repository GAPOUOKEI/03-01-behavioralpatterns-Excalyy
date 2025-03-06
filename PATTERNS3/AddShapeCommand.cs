class AddShapeCommand : ICommand
{
    private List<Shape> _shapes;
    private Shape _shape;

    public AddShapeCommand(List<Shape> shapes, Shape shape)
    {
        _shapes = shapes;
        _shape = shape;
    }

    public void Execute()
    {
        _shapes.Add(_shape);
        Console.WriteLine($"Добавлена фигура: {_shape.Type}");
    }
}