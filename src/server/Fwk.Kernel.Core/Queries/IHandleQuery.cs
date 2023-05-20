using Fwk.Kernel.Core.Metadata;
using Fwk.Kernel.Core.Results;

namespace Fwk.Kernel.Core.Queries
{
    public interface IHandleQuery<in TQuery, TResult>
        where TQuery : IQuery
        where TResult : IActionResult
    {
        ValueTask<ApplicationResult<TResult>> Handle(TQuery query, ISystemMetadata metadata);
    }
}
