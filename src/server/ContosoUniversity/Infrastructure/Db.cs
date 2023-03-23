using System;
using System.Threading.Tasks;
using ContosoUniversity.Infrastructure.Providers;
using Dapper.Contrib.Extensions;

namespace ContosoUniversity.Infrastructure
{
    public class Db
    {
        private readonly IConnectionProvider _connectionProvider;

        public Db(IConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider ?? throw new ArgumentNullException(nameof(connectionProvider));
        }

        public async Task<long> InsertAsync<T>(T model) where T : class, IDatabaseModel
        {
            var connection = _connectionProvider.Connection;
            return await connection.InsertAsync(model);
        }
    }
}
