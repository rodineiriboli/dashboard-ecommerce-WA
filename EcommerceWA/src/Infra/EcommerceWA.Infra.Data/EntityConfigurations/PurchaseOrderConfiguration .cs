using EcommerceWA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceWA.Infra.Data.EntityConfigurations
{
    public class PurchaseOrderConfiguration : IEntityTypeConfiguration<PurchaseOrder>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrder> builder)
        {
            builder.Property(p => p.Address).HasMaxLength(300).IsRequired();

            builder
                .HasMany(s => s.Product);

            builder.HasData(
                new PurchaseOrder
                {
                    Id = 1,
                    Address = "Address 1",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(1),
                    Number = 1,
                    DeliveryTeamId = 1
                },
                new PurchaseOrder
                {
                    Id = 2,
                    Address = "Address 2",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(3),
                    Number = 2,
                    DeliveryTeamId = 1
                },
                new PurchaseOrder
                {
                    Id = 3,
                    Address = "Address 3",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(5),
                    Number = 3,
                    DeliveryTeamId = 1
                }, new PurchaseOrder
                {
                    Id = 4,
                    Address = "Address 4",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(5),
                    Number = 4,
                    DeliveryTeamId = 1
                }, new PurchaseOrder
                {
                    Id = 5,
                    Address = "Address 5",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(5),
                    Number = 5,
                    DeliveryTeamId = 1
                },
                new PurchaseOrder
                {
                    Id = 6,
                    Address = "Address 6",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(1),
                    Number = 6,
                    DeliveryTeamId = 1
                },
                new PurchaseOrder
                {
                    Id = 7,
                    Address = "Address 7",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(1),
                    Number = 7,
                    DeliveryTeamId = 1
                },
                new PurchaseOrder
                {
                    Id = 8,
                    Address = "Address 8",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(1),
                    Number = 8,
                    DeliveryTeamId = 4
                },
                new PurchaseOrder
                {
                    Id = 9,
                    Address = "Address 9",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(1),
                    Number = 9,
                    DeliveryTeamId = 4
                },
                new PurchaseOrder
                {
                    Id = 10,
                    Address = "Address 10",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(1),
                    Number = 10,
                    DeliveryTeamId = 4
                },
                new PurchaseOrder
                {
                    Id = 11,
                    Address = "Address 11",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(3),
                    Number = 11,
                    DeliveryTeamId = 4
                },
                new PurchaseOrder
                {
                    Id = 12,
                    Address = "Address 12",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(3),
                    Number = 12,
                    DeliveryTeamId = 4
                },
                new PurchaseOrder
                {
                    Id = 13,
                    Address = "Address 13",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(3),
                    Number = 13,
                    DeliveryTeamId = 3
                },
                new PurchaseOrder
                {
                    Id = 14,
                    Address = "Address 14",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(2),
                    Number = 14,
                    DeliveryTeamId = 3
                },
                new PurchaseOrder
                {
                    Id = 15,
                    Address = "Address 15",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(2),
                    Number = 15,
                    DeliveryTeamId = 3
                },
                new PurchaseOrder
                {
                    Id = 16,
                    Address = "Address 16",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(2),
                    Number = 16,
                    DeliveryTeamId = 3
                },
                new PurchaseOrder
                {
                    Id = 17,
                    Address = "Address 17",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(7),
                    Number = 17,
                    DeliveryTeamId = 2
                },
                new PurchaseOrder
                {
                    Id = 18,
                    Address = "Address 18",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(7),
                    Number = 18,
                    DeliveryTeamId = 2
                },
                new PurchaseOrder
                {
                    Id = 19,
                    Address = "Address 19",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(7),
                    Number = 19,
                    DeliveryTeamId = 2
                },
                new PurchaseOrder
                {
                    Id = 20,
                    Address = "Address 20",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(1),
                    Number = 20,
                    DeliveryTeamId = 2
                },
                new PurchaseOrder
                {
                    Id = 21,
                    Address = "Address 21",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(1),
                    Number = 21,
                    DeliveryTeamId = 2
                },
                new PurchaseOrder
                {
                    Id = 22,
                    Address = "Address 22",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(1),
                    Number = 22,
                    DeliveryTeamId = 2
                },
                new PurchaseOrder
                {
                    Id = 23,
                    Address = "Address 23",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(1),
                    Number = 23,
                    DeliveryTeamId = 2
                },
                new PurchaseOrder
                {
                    Id = 24,
                    Address = "Address 24",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(4),
                    Number = 24,
                    DeliveryTeamId = 2
                },
                new PurchaseOrder
                {
                    Id = 25,
                    Address = "Address 25",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(5),
                    Number = 25,
                    DeliveryTeamId = 1
                },
                new PurchaseOrder
                {
                    Id = 26,
                    Address = "Address 26",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(5),
                    Number = 26,
                    DeliveryTeamId = 3
                },
                new PurchaseOrder
                {
                    Id = 27,
                    Address = "Address 27",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(5),
                    Number = 27,
                    DeliveryTeamId = 3
                },
                new PurchaseOrder
                {
                    Id = 28,
                    Address = "Address 28",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(3),
                    Number = 28,
                    DeliveryTeamId = 3
                },
                new PurchaseOrder
                {
                    Id = 29,
                    Address = "Address 29",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(3),
                    Number = 29,
                    DeliveryTeamId = 3
                },
                new PurchaseOrder
                {
                    Id = 30,
                    Address = "Address 30",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(3),
                    Number = 30,
                    DeliveryTeamId = 3
                },
                new PurchaseOrder
                {
                    Id = 31,
                    Address = "Address 31",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(3),
                    Number = 31,
                    DeliveryTeamId = 3
                },
                new PurchaseOrder
                {
                    Id = 32,
                    Address = "Address 32",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(3),
                    Number = 32,
                    DeliveryTeamId = 1
                },
                new PurchaseOrder
                {
                    Id = 33,
                    Address = "Address 33",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(2),
                    Number = 33,
                    DeliveryTeamId = 2
                },
                new PurchaseOrder
                {
                    Id = 34,
                    Address = "Address 34",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(2),
                    Number = 34,
                    DeliveryTeamId = 2
                },
                new PurchaseOrder
                {
                    Id = 35,
                    Address = "Address 35",
                    CreationDate = System.DateTime.Now,
                    DeliveryDate = System.DateTime.Now.AddDays(2),
                    Number = 35,
                    DeliveryTeamId = 2
                }
            );
        }
    }
}
