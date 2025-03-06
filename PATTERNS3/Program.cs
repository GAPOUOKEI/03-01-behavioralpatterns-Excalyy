namespace PATTERNS3
{   /*
     * ФИО студента: Давиденко
     * номер варианта: 6
     * условие задачи (скопировать из листа задания): Создайте простое графическое приложение, где пользователи могут рисовать фигуры 
     * (например, круги, квадраты) и управлять ими через команды: "Добавить фигуру", "Удалить фигуру", "Переместить фигуру".
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            CommandManager commandManager = new CommandManager();

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Добавить фигуру");
                Console.WriteLine("2. Удалить фигуру");
                Console.WriteLine("3. Переместить фигуру");
                Console.WriteLine("4. Показать все фигуры");
                Console.WriteLine("5. Показать историю команд");
                Console.WriteLine("6. Выйти");
                Console.Write("Ваш выбор: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите тип фигуры (круг, квадрат): ");
                        string type = Console.ReadLine();
                        Console.Write("Введите координату X: ");
                        int x = int.Parse(Console.ReadLine());
                        Console.Write("Введите координату Y: ");
                        int y = int.Parse(Console.ReadLine());
                        Shape shape = new Shape(type, x, y);
                        commandManager.ExecuteCommand(new AddShapeCommand(shapes, shape));
                        break;

                    case 2:
                        Console.Write("Введите индекс фигуры для удаления: ");
                        int index = int.Parse(Console.ReadLine());
                        commandManager.ExecuteCommand(new DeleteShapeCommand(shapes, index));
                        break;

                    case 3:
                        Console.Write("Введите индекс фигуры для перемещения: ");
                        int moveIndex = int.Parse(Console.ReadLine());
                        if (moveIndex >= 0 && moveIndex < shapes.Count)
                        {
                            Console.Write("Введите новую координату X: ");
                            int newX = int.Parse(Console.ReadLine());
                            Console.Write("Введите новую координату Y: ");
                            int newY = int.Parse(Console.ReadLine());
                            commandManager.ExecuteCommand(new MoveShapeCommand(shapes[moveIndex], newX, newY));
                        }
                        else
                        {
                            Console.WriteLine("Неверный индекс фигуры.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nСписок фигур:");
                        for (int i = 0; i < shapes.Count; i++)
                        {
                            Console.Write($"{i}. ");
                            shapes[i].Display();
                        }
                        break;

                    case 5:
                        commandManager.ShowCommands();
                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}
