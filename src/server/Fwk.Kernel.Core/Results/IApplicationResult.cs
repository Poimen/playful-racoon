using Fwk.Kernel.Core.Results.Messages;

namespace Fwk.Kernel.Core.Results
{
    public interface IApplicationResult
    {
        IApplicationMessages Messages { get; }
    }
}
