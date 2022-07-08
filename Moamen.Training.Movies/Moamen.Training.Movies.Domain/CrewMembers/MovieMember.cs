using Moamen.Training.Movies.Domain.Common;
using Moamen.Training.Movies.Domain.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Domain.CrewMembers
{
    public class MovieMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string WebsiteUrl { get; set; }
        public string Bio { get; set; }
        public double HeightInInches { get; set; }
        public DateOnly DOB { get; set; }
        public MovieMemberRoleType Role { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public List<MovieMembers> MovieMembers { get; set; }
    }
}
