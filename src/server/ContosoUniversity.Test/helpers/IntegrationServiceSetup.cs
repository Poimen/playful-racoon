using System.IO;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ContosoUniversity.Test.helpers
{
    public static class IntegrationServiceSetup
    {
        private static readonly ServiceCollection _services;

        static IntegrationServiceSetup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .AddEnvironmentVariables();

            var configuration = builder.Build();

            var startup = new Startup(configuration);
            _services = new ServiceCollection();
            _services.AddLogging();
            startup.ConfigureServices(_services);
        }

        public static T GetService<T>()
        {
            var provider = _services.BuildServiceProvider();
            return provider.GetService<T>();
        }
    }
}
