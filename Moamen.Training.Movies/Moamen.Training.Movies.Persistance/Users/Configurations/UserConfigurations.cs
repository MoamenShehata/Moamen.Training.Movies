using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moamen.Training.Movies.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Persistance.Users.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
              .ToTable("Users");

            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Name)
                .HasColumnOrder(1)
                .IsRequired();

            builder
                .Property(c => c.Email)
                .HasColumnOrder(2);

            builder
                .Property(c => c.PasswordHash)
                .HasColumnOrder(3)
                .IsRequired();

            builder
                .Property(c => c.PasswordSalt)
                .HasColumnOrder(4)
                .IsRequired();
        }
    }
}
