using System;
using System.Data;
using ContosoUniversity.settings;
using MySql.Data.MySqlClient;

namespace ContosoUniversity.Infrastructure.Factories
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly string _connectionString;

        public ConnectionFactory(DatabaseSettings settings)
        {
            if (settings == null) throw new ArgumentNullException(nameof(settings));

            _connectionString = settings.ConnectionString;
        }

        public IDbConnection CreateMySqlConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
