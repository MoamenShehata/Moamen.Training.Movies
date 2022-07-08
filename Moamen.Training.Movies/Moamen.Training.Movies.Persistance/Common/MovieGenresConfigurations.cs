using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moamen.Training.Movies.Domain.Common;

namespace Moamen.Training.Movies.Persistance.Common
{
    public class MovieGenresConfigurations : IEntityTypeConfiguration<MovieGenres>
    {
        public void Configure(EntityTypeBuilder<MovieGenres> builder)
        {
            builder.ToTable("MoviesGenres");

            builder
                .HasKey(mm => new { mm.MovieId, mm.GenreId });

            builder
                .HasOne(mm => mm.Movie)
                .WithMany(b => b.MovieGenres)
                .HasForeignKey(bc => bc.MovieId);
            builder
                .HasOne(mm => mm.Genre)
                .WithMany(c => c.MovieGenres)
                .HasForeignKey(bc => bc.GenreId);
        }
    }


}
