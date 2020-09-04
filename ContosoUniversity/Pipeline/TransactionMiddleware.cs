using System;
using System.Threading.Tasks;
using ContosoUniversity.Infrastructure.Providers;
using Microsoft.AspNetCore.Http;

namespace ContosoUniversity.Pipeline
{
    public class TransactionMiddleware : IMiddleware
    {
        private readonly ITransactionProvider _transactionProvider;

        public TransactionMiddleware(ITransactionProvider transactionProvider)
        {
            _transactionProvider = transactionProvider ?? throw new ArgumentNullException(nameof(transactionProvider));
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await _transactionProvider.ExecuteInTransactionAsync(async () => await next(context));
        }
    }
}
