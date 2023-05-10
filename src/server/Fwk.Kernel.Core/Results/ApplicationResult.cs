using Fwk.Kernel.Core.Optional;

namespace Fwk.Kernel.Core.Results
{
    public class ApplicationResult<T>
        where T : IActionResult
    {
        public Optional<T> Result { get; protected set; }

        public IApplicationMessages Messages => throw new NotImplementedException();

        private ApplicationResult(T result)
        {
            Result = Optional<T>.Some(result);
        }

        protected ApplicationResult()
        {
            Result = Optional<T>.None();
        }

        public static ValueTask<ApplicationResult<T>> Success(T result)
        {
            return ValueTask.FromResult(new ApplicationResult<T>(result));
        }

        public static ValueTask<ApplicationResult<T>> Success()
        {
            return ValueTask.FromResult(new ApplicationResult<T>());
        }
    }

    public class VoidApplicationResult : IActionResult { }

    public class ApplicationResult : ApplicationResult<VoidApplicationResult>, IActionResult
    {
        public static new ValueTask<ApplicationResult> Success()
        {
            var result = new ApplicationResult
            {
                Result = Optional<VoidApplicationResult>.Some(new VoidApplicationResult())
            };

            return ValueTask.FromResult(result);
        }
    }
}
