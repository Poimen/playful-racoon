namespace Fwk.Kernel.Core.Results.Messages
{
    public class ApplicationMessages : IApplicationMessages
    {
        private readonly List<string> _errorMessages;

        public bool WasSuccessful => _errorMessages.Count == 0;

        public IEnumerable<string> Messages => _errorMessages;

        private ApplicationMessages()
        {
            _errorMessages = new List<string>();
        }

        public ApplicationMessages(IApplicationMessages messages) : this()
        {
            Aggregate(messages);
        }

        public static IApplicationMessages Empty()
        {
            return new ApplicationMessages();
        }

        public void Aggregate(IApplicationMessages messages)
        {
            _errorMessages.AddRange(messages.Messages);
        }

        public void Add(string message)
        {
            _errorMessages.Add(message);
        }
    }
}
