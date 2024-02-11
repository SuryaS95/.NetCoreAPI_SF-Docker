using Microsoft.Extensions.Configuration;
using Snowflake.Data.Client;
using System.Data;

namespace Movies.Infrastructure.Context
{
    public class SnowflakeContext
    {
        private readonly IConfiguration _configuration;
        public string _sfConnection;

        public SnowflakeContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _sfConnection = _configuration.GetConnectionString("sfConnectionString");
        }

        public IDbConnection createSfConnection()
        {
            var connection = new SnowflakeDbConnection();
            connection.ConnectionString = _sfConnection;
            return connection;
        }
    }
}
