using ContosoUniversity.Infrastructure.Factories;
using ContosoUniversity.Infrastructure.Providers;
using ContosoUniversity.Pipeline;
using ContosoUniversity.settings;
using Microsoft.Extensions.DependencyInjection;

namespace ContosoUniversity.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddScopeDatabase(this IServiceCollection services)
        {
            services.AddScoped<IDbFactory, DbFactory>();
            services.AddScoped<IConnectionFactory, ConnectionFactory>();

            services.AddSingleton<DatabaseSettings>();
            services.AddScoped<ITransactionProvider, TransactionProvider>();
            services.AddScoped<IConnectionProvider, ConnectionProvider>();

            services.AddScoped<TransactionMiddleware>();
        }
    }
}
