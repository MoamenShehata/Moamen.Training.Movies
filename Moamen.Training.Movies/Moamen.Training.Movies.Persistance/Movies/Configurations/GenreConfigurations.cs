using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moamen.Training.Movies.Domain.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Persistance.Movies.Configurations
{
    public class GenreConfigurations : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder
               .ToTable("Genres");

            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Type)
                .HasColumnOrder(1)
                .IsRequired();
        }
    }
}
