using Moamen.Training.Movies.Domain.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Application.Movies.Query
{
    public interface IGetMoviesQuery
    {
        IEnumerable<Movie> Execute();
    }
}
