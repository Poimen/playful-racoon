using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Fwk.Infrastructure.Host.WebAPI.Setup
{
    public class WebHostInstaller
    {
        public static WebApplication Install(string[] args, Action<WebApplicationBuilder>? configure = null)
        {
            var builder = BuildWebApplication(args);
            configure?.Invoke(builder);

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.MapControllers();

            return app;
        }

        private static WebApplicationBuilder BuildWebApplication(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddLogging(opts =>
            {
                opts.ClearProviders();
                opts.AddConsole();
            });
            builder.Services.AddControllers();
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddHealthChecks(); // TODO: Make health checks available

            return builder;
        }
    }
}
