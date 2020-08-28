using System;

namespace ContosoUniversity.Infrastructure
{
    public class DbFactory : IDbFactory
    {
        private readonly IConnectionFactory _connectionFactory;

        public DbFactory(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory ?? throw new ArgumentNullException(nameof(connectionFactory));
        }

        public Db NewDb()
        {
            return new Db(_connectionFactory);
        }
    }
}
