namespace consoleProject
{
    /*
     * ФИО студента: Давиденко
     * номер варианта: 6
     * условие задачи (скопировать из листа задания): Напишите приложение для логирования действий, в котором общий процесс логирования будет 
     *   определен через шаблонный метод, а конкретные действия - в дочерних классах.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип логгера:");
            Console.WriteLine("1. Логирование в файл");
            Console.WriteLine("2. Логирование в консоль");
            int choice = int.Parse(Console.ReadLine());

            Logger logger = null;

            switch (choice)
            {
                case 1:
                    logger = new FileLogger();
                    break;
                case 2:
                    logger = new ConsoleLogger();
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    return;
            }

            Console.WriteLine("Введите сообщение для логирования:");
            string message = Console.ReadLine();

            logger.Log(message);
        }
    }
}