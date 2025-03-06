class ClosedState : IState
{
    public void HandleRequest()
    {
        Console.WriteLine("Запрос в состоянии: Закрыт. Обработка завершена.");
    }
}