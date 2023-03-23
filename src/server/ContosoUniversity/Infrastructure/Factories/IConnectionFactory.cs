using System.Data;

namespace ContosoUniversity.Infrastructure.Factories
{
    public interface IConnectionFactory
    {
        IDbConnection CreateMySqlConnection();
    }
}
