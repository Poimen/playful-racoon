namespace Fwk.Kernel.Core.Commands
{
    public interface IHandleCommand<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }

    public interface IHandleCommand<T, TCommandResult>
        where T : ICommand
        where TCommandResult : new()
    {
        ICommandResult<TCommandResult> Handle(T command);
    }
}
