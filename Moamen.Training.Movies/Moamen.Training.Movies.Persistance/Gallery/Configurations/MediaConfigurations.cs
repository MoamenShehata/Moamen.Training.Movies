using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moamen.Training.Movies.Domain.Gallery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Persistance.Gallery.Configurations
{
    public class MediaConfigurations : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder
              .ToTable("Medias");

            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Url)
                .HasColumnOrder(1)
                .IsRequired();

            builder
                .Property(c => c.MediaType)
                .HasColumnOrder(2)
                .IsRequired();
        }
    }
}
