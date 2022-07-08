using AutoMapper;
using Moamen.Training.Movies.API.Movies.DTOs;
using Moamen.Training.Movies.Domain.Movies;

namespace Moamen.Training.Movies.API.Movies.Mappers
{
    public class MoviesProfile : Profile
    {
        public MoviesProfile()
        {
            CreateMap<Movie, MovieGet>()
                .ForMember(mg => mg.Rating, op => op.MapFrom(m => $"{(int)m.Rating}/10"));
        }

    }
}
