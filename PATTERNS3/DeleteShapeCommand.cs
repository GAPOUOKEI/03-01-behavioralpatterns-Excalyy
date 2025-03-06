class DeleteShapeCommand : ICommand
{
    private List<Shape> _shapes;
    private int _index;

    public DeleteShapeCommand(List<Shape> shapes, int index)
    {
        _shapes = shapes;
        _index = index;
    }

    public void Execute()
    {
        if (_index >= 0 && _index < _shapes.Count)
        {
            var shape = _shapes[_index];
            _shapes.RemoveAt(_index);
            Console.WriteLine($"Удалена фигура: {shape.Type}");
        }
        else
        {
            Console.WriteLine("Неверный индекс фигуры.");
        }
    }
}