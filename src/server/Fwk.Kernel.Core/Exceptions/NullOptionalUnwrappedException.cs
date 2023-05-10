namespace Fwk.Kernel.Core.Exceptions
{
    public class NullOptionalUnwrappedException: Exception
    {
        public NullOptionalUnwrappedException()
        {
        }

        public NullOptionalUnwrappedException(string message) : base(message)
        {
        }

        public NullOptionalUnwrappedException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
