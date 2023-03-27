namespace Fwk.Kernel.Core
{
    public interface IApplicationMessages
    {
        bool WasSuccessful { get; }

        void AddError(string message);
        void Aggregate(ApplicationMessages messages);
    }
}