namespace Fwk.Kernel.Core.Queries
{
    public interface IHandleQuery<T> where T : IQuery
    {
        void Handle(T query);
    }
}
