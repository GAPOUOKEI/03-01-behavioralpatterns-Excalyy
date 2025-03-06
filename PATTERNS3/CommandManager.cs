class CommandManager
{
    private List<ICommand> _commands = new List<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _commands.Add(command);
    }

    public void ShowCommands()
    {
        Console.WriteLine("\nИстория команд:");
        foreach (var command in _commands)
        {
            Console.WriteLine(command.GetType().Name);
        }
    }
}