using System.Data;

namespace ContosoUniversity.Infrastructure
{
    public interface IConnectionFactory
    {
        IDbConnection CreateMySqlConnection();
    }
}
