class ResolvedState : IState
{
    public void HandleRequest()
    {
        Console.WriteLine("Запрос в состоянии: Решен. Ожидает подтверждения закрытия.");
    }
}