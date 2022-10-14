using EcommerceWA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceWA.Infra.Data.EntityConfigurations
{
    public class DeliveryTeamConfiguration : IEntityTypeConfiguration<DeliveryTeam>
    {
        public void Configure(EntityTypeBuilder<DeliveryTeam> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(30).IsRequired();
            builder.Property(b => b.Description).HasMaxLength(200).IsRequired();
            builder.Property(b => b.VehiclePlate).HasMaxLength(30).IsRequired();

            builder.HasData(
                new DeliveryTeam
                {
                    Id = 1,
                    Name = "DeliveryTeam 1",
                    Description = "DeliveryTeam Description 1",
                    VehiclePlate = "MJG-5H63"
                },
                new DeliveryTeam
                {
                    Id = 2,
                    Name = "DeliveryTeam 2",
                    Description = "DeliveryTeam Description 2",
                    VehiclePlate = "MIR-1B66"
                },
                new DeliveryTeam
                {
                    Id = 3,
                    Name = "DeliveryTeam 3",
                    Description = "DeliveryTeam Description 3",
                    VehiclePlate = "MHB-2K23"
                },
                new DeliveryTeam
                {
                    Id = 4,
                    Name = "DeliveryTeam 4",
                    Description = "DeliveryTeam Description 4",
                    VehiclePlate = "MOP-1A23"
                }
            );
        }
    }
}
