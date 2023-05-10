namespace Fwk.Kernel.Core.Results.Messages
{
    public interface IApplicationMessages
    {
        IEnumerable<string> Messages { get; }

        void Add(string message);

        void Aggregate(IApplicationMessages messages);
    }
}
