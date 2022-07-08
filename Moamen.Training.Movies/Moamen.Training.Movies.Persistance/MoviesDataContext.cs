using Microsoft.EntityFrameworkCore;
using Moamen.Training.Movies.Domain.CrewMembers;
using Moamen.Training.Movies.Domain.Gallery;
using Moamen.Training.Movies.Domain.Movies;
using Moamen.Training.Movies.Domain.Users;
using Moamen.Training.Movies.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Persistance
{
    public class MoviesDataContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<MediaRole> MediaRoles { get; set; }
        public DbSet<MovieMember> MovieMembers { get; set; }
        public DbSet<MovieMemberRole> MovieMemberRoles { get; set; }
        public DbSet<MovieGenres> MoviesGenres { get; set; }
        public DbSet<MovieMembers> MoviesMembers { get; set; }
        public DbSet<MovieUsers> MoviesUsers { get; set; }
        public DbSet<User> Users { get; set; }

        public MoviesDataContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=.;Database=Movies-DB;Trusted_Connection=True;");
    }
}
