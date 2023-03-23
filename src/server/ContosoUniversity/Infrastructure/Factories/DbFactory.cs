using System;
using ContosoUniversity.Infrastructure.Providers;

namespace ContosoUniversity.Infrastructure.Factories
{
    public class DbFactory : IDbFactory
    {
        private readonly IConnectionProvider _connectionProvider;

        public DbFactory(IConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider ?? throw new ArgumentNullException(nameof(connectionProvider));
        }

        public Db NewDb()
        {
            return new Db(_connectionProvider);
        }
    }
}
