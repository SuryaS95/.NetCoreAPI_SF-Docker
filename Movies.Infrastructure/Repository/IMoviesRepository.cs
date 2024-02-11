namespace Movies.Infrastructure.Repositories
{
    public interface IMoviesRepository
    {
        Task<int> GetCount();
    }
}
