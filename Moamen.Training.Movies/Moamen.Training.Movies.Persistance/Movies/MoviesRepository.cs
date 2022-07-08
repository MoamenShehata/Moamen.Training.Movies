using Moamen.Training.Movies.Application.Common;
using Moamen.Training.Movies.Domain.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Persistance.Movies
{
    public class MoviesRepository : IRepository<Movie>
    {
        private readonly MoviesDataContext dataContext;
        public MoviesRepository(MoviesDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<Movie> GetAll() => dataContext.Movies;
    }
}
