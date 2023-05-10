namespace Fwk.Kernel.Core.Results
{
    public interface IApplicationMessages
    {
        IEnumerable<string> Messages { get; }

        void Add(string message);

        void Aggregate(IApplicationMessages messages);
    }
}
