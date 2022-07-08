using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moamen.Training.Movies.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Persistance.Common
{
    public class MovieMembersConfigurations : IEntityTypeConfiguration<MovieMembers>
    {
        public void Configure(EntityTypeBuilder<MovieMembers> builder)
        {
            builder.ToTable("MoviesMembers");

            builder
                .HasKey(mm => new { mm.MovieId, mm.MovieMemberId });

            builder
                .HasOne(mm => mm.Movie)
                .WithMany(b => b.MovieMembers)
                .HasForeignKey(bc => bc.MovieId);
            builder
                .HasOne(mm => mm.MovieMember)
                .WithMany(c => c.MovieMembers)
                .HasForeignKey(bc => bc.MovieMemberId);
        }
    }


}
