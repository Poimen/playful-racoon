namespace Fwk.Kernel.Core
{
    public class ApplicationMessages : IApplicationMessages
    {
        private readonly List<string> _errorMessages;

        public bool WasSuccessful => _errorMessages.Count == 0;

        private ApplicationMessages()
        {
            _errorMessages = new List<string>();
        }

        public static ApplicationMessages Empty()
        {
            return new ApplicationMessages();
        }

        public void Aggregate(ApplicationMessages messages)
        {
            _errorMessages.AddRange(messages._errorMessages);
        }

        public void AddError(string message)
        {
            _errorMessages.Add(message);
        }
    }
}
