using Fwk.Kernel.Core.Exceptions;

namespace Fwk.Kernel.Core.Optional
{
    public class Optional<T>
    {
        public bool IsNone { get; }

        public bool IsSome => !IsNone;

        public T? Value { get; }

        private Optional(T value)
        {
            Value = value;
            IsNone = false;
        }

        private Optional() => IsNone = true;

        public T Unwrap()
        {
            return IsNone || Value is null
                ? throw new NullOptionalUnwrappedException("Attempted to unwrap optional value that is null")
                : Value;
        }

        public static Optional<T> None() => new();

        public static Optional<T> Some(T value) => new(value);

        public TResult Match<TResult>(Func<T, TResult> some, Func<TResult> none)
        {
            return IsNone || Value is null ? none() : some(Value);
        }
    }
}
