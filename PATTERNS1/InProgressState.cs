class InProgressState : IState
{
    public void HandleRequest()
    {
        Console.WriteLine("Запрос в состоянии: В процессе. Находится в работе.");
    }
}
