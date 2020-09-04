using System.Data;

namespace ContosoUniversity.Infrastructure.Providers
{
    public interface IConnectionProvider
    {
        IDbConnection Connection { get; }
    }
}
