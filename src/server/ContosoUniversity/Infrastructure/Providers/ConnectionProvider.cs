using System;
using System.Data;
using ContosoUniversity.Infrastructure.Factories;

namespace ContosoUniversity.Infrastructure.Providers
{
    public class ConnectionProvider : IConnectionProvider
    {
        public IDbConnection Connection { get; }

        public ConnectionProvider(IConnectionFactory connectionFactory)
        {
            if (connectionFactory == null) throw new ArgumentNullException(nameof(connectionFactory));

            Connection = connectionFactory.CreateMySqlConnection();
        }
    }
}
