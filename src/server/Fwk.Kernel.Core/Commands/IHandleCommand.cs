using Fwk.Kernel.Core.Metadata;
using Fwk.Kernel.Core.Results;

namespace Fwk.Kernel.Core.Commands
{
    public interface IHandleCommand<in TCommand, TResult>
        where TCommand : ICommand
        where TResult : IActionResult
    {
        ValueTask<ApplicationResult<TResult>> Handle(TCommand command, ISystemMetadata metadata);
    }

    public interface IHandleCommand<in TCommand>
        where TCommand : ICommand
    {
        ValueTask<ApplicationResult> Handle(TCommand command, ISystemMetadata metadata);
    }
}
