using System;
using System.IO;

class FileLogger : Logger
{
    private StreamWriter _writer;

    protected override void OpenLog()
    {
        _writer = new StreamWriter("log.txt", true);
        Console.WriteLine("Файл лога открыт.");
    }

    protected override void WriteLog(string message)
    {
        _writer.WriteLine($"{DateTime.Now}: {message}");
        Console.WriteLine("Запись в файл выполнена.");
    }

    protected override void CloseLog()
    {
        _writer.Close();
        Console.WriteLine("Файл лога закрыт.");
    }
}