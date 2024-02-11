using Movies.Infrastructure.Context;
using Dapper;

namespace Movies.Infrastructure.Repositories
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly SnowflakeContext _snowflakeContext;
        public MoviesRepository(SnowflakeContext snowflakeContext)
        {
            _snowflakeContext= snowflakeContext;
        }

        public async Task<int> GetCount()
        {
            try
            {
                using var connection = _snowflakeContext.createSfConnection();
                connection.Open();
                var result = await connection.ExecuteAsync("select count(*) from SURYASF.SAMPLEDATA.PRODUCTS");
                return result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return 0;
        }
    }
}
