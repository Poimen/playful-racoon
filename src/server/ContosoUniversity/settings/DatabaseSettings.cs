using Microsoft.Extensions.Configuration;

namespace ContosoUniversity.settings
{
    public class DatabaseSettings
    {
        public string ConnectionString { get; }

        public DatabaseSettings(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");;
        }
    }
}
