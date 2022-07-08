using Moamen.Training.Movies.Domain.CrewMembers;
using Moamen.Training.Movies.Domain.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Domain.Common
{
    public class MovieMembers
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int MovieMemberId { get; set; }
        public MovieMember MovieMember { get; set; }
    }
}
