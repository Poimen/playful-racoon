using System;
using ContosoUniversity.Migrator.Migrations;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace ContosoUniversity.Migrator
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = CreateServices();

            using var scope = serviceProvider.CreateScope();
            UpdateDatabase(scope.ServiceProvider);
        }

        private static IServiceProvider CreateServices()
        {
            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddMySql5()
                    // TODO : read from configuration
                    .WithGlobalConnectionString("host=localhost;port=3306;user id=uni;password=pa$$word;database=uni;")
                    .ScanIn(typeof(CreateStudentTable).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }

        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            // TODO : migrate up and down
            runner.MigrateUp();
        }
    }
}
