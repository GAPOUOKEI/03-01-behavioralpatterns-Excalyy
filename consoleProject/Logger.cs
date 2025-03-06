using System;

abstract class Logger
{

    public void Log(string message)
    {
        OpenLog();
        WriteLog(message);
        CloseLog();
    }


    protected abstract void OpenLog();
    protected abstract void WriteLog(string message);
    protected abstract void CloseLog();
}