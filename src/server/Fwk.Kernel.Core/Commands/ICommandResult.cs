namespace Fwk.Kernel.Core.Commands
{
    public interface ICommandResult
    {
        IApplicationMessages Messages { get; }
    }

    public interface ICommandResult<T> : ICommandResult where T : new()
    {
    }
}
