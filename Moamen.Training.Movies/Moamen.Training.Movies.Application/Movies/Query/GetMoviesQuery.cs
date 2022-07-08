using Moamen.Training.Movies.Application.Common;
using Moamen.Training.Movies.Domain.Movies;

namespace Moamen.Training.Movies.Application.Movies.Query
{
    public class GetMoviesQuery : IGetMoviesQuery
    {
        private readonly IRepository<Movie> moviesRepo;
        public GetMoviesQuery(IRepository<Movie> moviesRepo)
        {
            this.moviesRepo = moviesRepo;
        }
        
        public IEnumerable<Movie> Execute()
        {
            return moviesRepo.GetAll();
        }
    }
}
