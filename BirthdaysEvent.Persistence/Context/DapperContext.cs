

using Microsoft.Extensions.Configuration;

namespace BirthdaysEvent.Persistence.Context
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = configuration.GetConnectionString("BirthdaysEventsDBConnection")!;
        }


    }
}
