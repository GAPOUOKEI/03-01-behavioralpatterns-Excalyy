class NewState : IState
{
    public void HandleRequest()
    {
        Console.WriteLine("Запрос в состоянии: Новый. Ожидает обработки.");
    }
}