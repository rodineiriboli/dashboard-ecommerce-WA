using EcommerceWA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceWA.Infra.Data.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(b => b.UserName).HasMaxLength(30).IsRequired();
            builder.Property(b => b.Password).HasMaxLength(30).IsRequired();
            builder.Property(b => b.Role).HasMaxLength(30).IsRequired();

            builder.HasData(
                new User
                {
                    Id = 1,
                    UserName = "user1",
                    Password = "user1",
                    Role = "manager"
                },
                new User
                {
                    Id = 2,
                    UserName = "user2",
                    Password = "user2",
                    Role = "basic"
                }
            );
        }
    }
}
