namespace PATTERNS1
{   /*
     * ФИО студента: Давиденко
     * номер варианта: 6
     * условие задачи (скопировать из листа задания): Напишите приложение, где клиенты могут находиться в различных состояниях 
     * (новый запрос, в процессе, решен, закрыт).Интерфейс изменяется в зависимости от состояния запроса.
     */
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            RequestContext context = new RequestContext();

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Перевести запрос в состояние 'В процессе'");
                Console.WriteLine("2. Перевести запрос в состояние 'Решен'");
                Console.WriteLine("3. Перевести запрос в состояние 'Закрыт'");
                Console.WriteLine("4. Выйти");
                Console.Write("Ваш выбор: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        context.SetState(new InProgressState());
                        break;
                    case 2:
                        context.SetState(new ResolvedState());
                        break;
                    case 3:
                        context.SetState(new ClosedState());
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        continue;
                }

                // Обработка запроса в текущем состоянии
                context.HandleRequest();
            }
        }
    }
}
