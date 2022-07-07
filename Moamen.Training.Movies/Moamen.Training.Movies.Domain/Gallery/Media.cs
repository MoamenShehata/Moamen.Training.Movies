using Moamen.Training.Movies.Domain.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Domain.Gallery
{
    public class Media : IHasOneMediaRole<MediaRole, int>, IHasOneMovie<Movie, int>
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int RoleId { get; set; }
        public MediaRole Role { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
