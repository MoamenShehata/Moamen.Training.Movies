using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moamen.Training.Movies.Domain.CrewMembers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Persistance.CrewMembers.Configurations
{
    public class MovieMemberConfigurations : IEntityTypeConfiguration<MovieMember>
    {
        public void Configure(EntityTypeBuilder<MovieMember> builder)
        {
            builder
               .ToTable("MovieMembers");

            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Name)
                .HasColumnOrder(1)
                .IsRequired();

            builder
                .Property(c => c.Country)
                .HasColumnOrder(2)
                .IsRequired();

            builder
                .Property(c => c.WebsiteUrl)
                .HasColumnOrder(3)
                .IsRequired(false);

            builder
                .Property(c => c.Bio)
                .HasColumnOrder(4)
                .IsRequired();

            builder
                .Property(c => c.DOB)
                .HasColumnOrder(5)
                .IsRequired();

            builder
                .Property(c => c.Role)
                .HasColumnOrder(6)
                .IsRequired();

            builder
                .Property(c => c.HeightInInches)
                .HasColumnOrder(7)
                .IsRequired();
        }
    }
}
