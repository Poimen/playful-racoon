using Fwk.Kernel.Core.Results;

namespace Fwk.Kernel.Core.Commands
{
    public interface IHandleCommand<TCommand, TResult>
        where TCommand : ICommand
        where TResult : IActionResult
    {
        ValueTask<ApplicationResult<TResult>> Handle(TCommand command);
    }

    public interface IHandleCommand<TCommand>
        where TCommand : ICommand
    {
        ValueTask<ApplicationResult> Handle(TCommand command);
    }
}
