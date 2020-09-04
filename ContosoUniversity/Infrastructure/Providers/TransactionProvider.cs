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
                Begin();
                await action();
                await Commit();
            }

            await Catcher.RethrowAsync(Execute, Rollback, Close);
        }

        private void Begin()
        {
            _dbConnection = _connectionProvider.Connection;
            _dbConnection.Open();

            _transaction = _dbConnection.BeginTransaction();
        }

        private Task Commit()
        {
            _transaction.Commit();
            return Task.CompletedTask;
        }

        private Task Rollback()
        {
            _transaction.Rollback();
            return Task.CompletedTask;
        }

        private Task Close()
        {
            _dbConnection.Close();
            _dbConnection.Dispose();

            return Task.CompletedTask;
        }
    }
}
