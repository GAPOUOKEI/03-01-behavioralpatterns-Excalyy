using System;

class ConsoleLogger : Logger
{
    protected override void OpenLog()
    {
        Console.WriteLine("Логирование в консоль начато.");
    }

    protected override void WriteLog(string message)
    {
        Console.WriteLine($"{DateTime.Now}: {message}");
    }

    protected override void CloseLog()
    {
        Console.WriteLine("Логирование в консоль завершено.");
    }
}