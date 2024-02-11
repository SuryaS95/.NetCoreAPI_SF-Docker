using Movies.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly IMoviesRepository _repository;
        public MoviesService(IMoviesRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> GetCount()
        {
            return await _repository.GetCount();
        }
    }
}
