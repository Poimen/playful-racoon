using System;
using System.Data;
using System.Threading.Tasks;

namespace ContosoUniversity.Infrastructure.Providers
{
    public class TransactionProvider : ITransactionProvider
    {
        private readonly IConnectionProvider _connectionProvider;
        private IDbConnection _dbConnection;
        private IDbTransaction _transaction;

        public TransactionProvider(IConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider ?? throw new ArgumentNullException(nameof(connectionProvider));
        }

        public async Task ExecuteInTransactionAsync(Func<Task> action)
        {
            async Task Execute()
            {
                await BeginAsync();
                await action();
                await CommitAsync();
            }

            await Catcher.RethrowAsync(Execute, RollbackAsync, CloseAsync);
        }

        private Task BeginAsync()
        {
            _dbConnection = _connectionProvider.Connection;
            _dbConnection.Open();

            _transaction = _dbConnection.BeginTransaction();

            return Task.CompletedTask;
        }

        private Task CommitAsync()
        {
            _transaction.Commit();
            return Task.CompletedTask;
        }

        private Task RollbackAsync()
        {
            _transaction.Rollback();
            return Task.CompletedTask;
        }

        private Task CloseAsync()
        {
            _dbConnection.Close();
            _dbConnection.Dispose();

            return Task.CompletedTask;
        }
    }
}
