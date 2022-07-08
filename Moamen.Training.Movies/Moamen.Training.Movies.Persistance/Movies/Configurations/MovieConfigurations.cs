using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moamen.Training.Movies.Domain.Common;
using Moamen.Training.Movies.Domain.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Persistance.Movies.Configurations
{
    public class MovieConfigurations : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder
               .ToTable("Movies");

            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Title)
                .HasColumnOrder(1)
                .IsRequired();

            builder
                .Property(c => c.Rating)
                .HasColumnOrder(2);

            builder
                .Property(c => c.Length)
                .HasColumnOrder(3)
                .IsRequired();

            builder
                .Property(c => c.Year)
                .HasColumnOrder(4)
                .IsRequired();

            builder
                .Property(c => c.Brief)
                .HasColumnOrder(5)
                .IsRequired();

            builder
                .HasMany(m => m.Medias)
                .WithOne(m => m.Movie)
                .HasForeignKey(m => m.MovieId);
        }
    }
}
