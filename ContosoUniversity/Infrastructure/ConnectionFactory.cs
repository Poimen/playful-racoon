using System;
using System.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace ContosoUniversity.Infrastructure
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly string _connectionString;

        public ConnectionFactory(IConfiguration configuration)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateMySqlConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
