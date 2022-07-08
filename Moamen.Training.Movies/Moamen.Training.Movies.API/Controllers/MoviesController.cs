using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moamen.Training.Movies.API.Movies.DTOs;
using Moamen.Training.Movies.Application.Movies.Query;

namespace Moamen.Training.Movies.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IGetMoviesQuery getMoviesQuery;
        private readonly IMapper mapper;

        public MoviesController(IGetMoviesQuery getMoviesQuery,
            IMapper mapper)
        {
            this.getMoviesQuery = getMoviesQuery;
            this.mapper = mapper;
        }

        [HttpGet()]
        public IActionResult GetMovies()
        {
            var moviesGet = mapper.Map<IEnumerable<MovieGet>>(getMoviesQuery.Execute());
            return new JsonResult(moviesGet);
        }
    }
}
