using Moamen.Training.Movies.Domain.Movies;
using Moamen.Training.Movies.Domain.Users;

namespace Moamen.Training.Movies.Domain.Common
{
    public class MovieUsers
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

    }
}
