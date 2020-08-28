using System;
using System.Data;
using Dapper.Contrib.Extensions;

namespace ContosoUniversity.Infrastructure
{
    public class Db
    {
        private readonly IConnectionFactory _connection;

        public Db(IConnectionFactory connectionFactory)
        {
            _connection = connectionFactory ?? throw new ArgumentNullException(nameof(connectionFactory));
        }

        public long Insert<T>(T model) where T : class, IDatabaseModel
        {
            using var conn = _connection.CreateMySqlConnection();
            return conn.Insert(model);
        }
    }
}
