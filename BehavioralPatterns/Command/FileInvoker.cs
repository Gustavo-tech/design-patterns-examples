using Command.Commands.Interfaces;

namespace Command;
internal class FileInvoker(ICommand command)
{
    private readonly ICommand _command = command;

    public void Execute()
    {
        _command.Execute();
    }
}
