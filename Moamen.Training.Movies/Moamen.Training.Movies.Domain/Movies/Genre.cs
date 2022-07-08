using Moamen.Training.Movies.Domain.Common;

namespace Moamen.Training.Movies.Domain.Movies
{

    public class Genre
    {
        public int Id { get; set; }
        public GenreType Type { get; set; }
        public ICollection<MovieGenres> MovieGenres { get; set; }
    }
}
