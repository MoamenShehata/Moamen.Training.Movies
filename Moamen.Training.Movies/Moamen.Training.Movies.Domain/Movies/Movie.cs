using Moamen.Training.Movies.Domain.Common;
using Moamen.Training.Movies.Domain.CrewMembers;
using Moamen.Training.Movies.Domain.Gallery;
using Moamen.Training.Movies.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Domain.Movies
{
    public class Movie : IIdentity<int>
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public string Brief { get; set; }
        public Rating Rating { get; set; }
        public TimeSpan Length { get; set; }
        public ICollection<MovieMember> Crew { get; set; }
        public List<MovieMembers> MovieMembers { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public List<MovieGenres> MovieGenres { get; set; }
        public ICollection<Media> Medias { get; set; }
        public ICollection<User> Users { get; set; }
        public List<MovieUsers> MovieUsers { get; set; }
    }
}
