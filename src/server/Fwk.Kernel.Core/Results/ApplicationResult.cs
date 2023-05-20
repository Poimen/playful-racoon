using Fwk.Kernel.Core.Optional;
using Fwk.Kernel.Core.Results.Messages;

namespace Fwk.Kernel.Core.Results
{
    public class ApplicationResult<T> : IApplicationResult
        where T : IActionResult
    {
        public Optional<T> Result { get; protected set; }

        public IApplicationMessages Messages { get; protected set; }

        private ApplicationResult(T result)
        {
            Result = Optional<T>.Some(result);
            Messages = ApplicationMessages.Empty();
        }

        private ApplicationResult(IApplicationMessages messages)
        {
            Result = Optional<T>.None();
            Messages = new ApplicationMessages(messages);
        }

        public static ApplicationResult<T> Success(T result)
        {
            return new ApplicationResult<T>(result);
        }

        public static ApplicationResult<T> Failed(IApplicationMessages messages)
        {
            return new ApplicationResult<T>(messages);
        }
    }

    public class VoidApplicationResult : IActionResult { }

    public class ApplicationResult : IApplicationResult
    {
        private readonly ApplicationResult<VoidApplicationResult> _innerResult;
        public IApplicationMessages Messages => _innerResult.Messages;

        private ApplicationResult()
        {
            _innerResult = ApplicationResult<VoidApplicationResult>.Success(new VoidApplicationResult());
        }

        private ApplicationResult(IApplicationMessages messages)
        {
            _innerResult = ApplicationResult<VoidApplicationResult>.Failed(messages);
        }

        public static ValueTask<ApplicationResult> Success()
        {
            return ValueTask.FromResult(new ApplicationResult());
        }

        public static ValueTask<ApplicationResult<T>> Success<T>(T value) where T : IActionResult
        {
            return ValueTask.FromResult(ApplicationResult<T>.Success(value));
        }

        public static ValueTask<ApplicationResult> Failed(IApplicationMessages messages)
        {
            return ValueTask.FromResult(new ApplicationResult(messages));
        }

        public static ValueTask<ApplicationResult<T>> Failed<T>(IApplicationMessages messages) where T : IActionResult
        {
            return ValueTask.FromResult(ApplicationResult<T>.Failed(messages));
        }
    }
}
