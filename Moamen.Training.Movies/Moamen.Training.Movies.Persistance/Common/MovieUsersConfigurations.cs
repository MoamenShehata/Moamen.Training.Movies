using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moamen.Training.Movies.Domain.Common;

namespace Moamen.Training.Movies.Persistance.Common
{
    public class MovieUsersConfigurations : IEntityTypeConfiguration<MovieUsers>
    {
        public void Configure(EntityTypeBuilder<MovieUsers> builder)
        {
            builder.ToTable("MoviesUsers");

            builder
                .HasKey(mm => new { mm.MovieId, mm.UserId });

            builder
                .HasOne(mm => mm.Movie)
                .WithMany(b => b.MovieUsers)
                .HasForeignKey(bc => bc.MovieId);
            builder
                .HasOne(mm => mm.User)
                .WithMany(c => c.MovieUsers)
                .HasForeignKey(bc => bc.UserId);
        }
    }


}
