using System;
using System.Threading.Tasks;

namespace ContosoUniversity.Infrastructure.Providers
{
    public interface ITransactionProvider
    {
        Task ExecuteInTransactionAsync(Func<Task> action);
    }
}
