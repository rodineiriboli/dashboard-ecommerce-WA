using EcommerceWA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceWA.Infra.Data.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(50).IsRequired();
            builder.Property(b => b.Description).HasMaxLength(200).IsRequired();
            builder.Property(b => b.Value).HasPrecision(10, 2);

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Product 1",
                    Description = "Product 1 Description",
                    Value = 1,
                    PurchaseOrderId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Product 2",
                    Description = "Product 2 Description",
                    Value = 2,
                    PurchaseOrderId = 1
                },
                new Product
                {
                    Id = 3,
                    Name = "Product 3",
                    Description = "Product 3 Description",
                    Value = 1,
                    PurchaseOrderId = 1
                },
                new Product
                {
                    Id = 4,
                    Name = "Product 4",
                    Description = "Product 4 Description",
                    Value = 1,
                    PurchaseOrderId = 2
                },
                new Product
                {
                    Id = 5,
                    Name = "Product 5",
                    Description = "Product 5 Description",
                    Value = 5,
                    PurchaseOrderId = 2
                },
                new Product
                {
                    Id = 6,
                    Name = "Product 6",
                    Description = "Product 6 Description",
                    Value = 6,
                    PurchaseOrderId = 2
                },
                new Product
                {
                    Id = 7,
                    Name = "Product 7",
                    Description = "Product 7 Description",
                    Value = 7,
                    PurchaseOrderId = 3
                },
                new Product
                {
                    Id = 8,
                    Name = "Product 8",
                    Description = "Product 8 Description",
                    Value = 8,
                    PurchaseOrderId = 3
                },
                new Product
                {
                    Id = 9,
                    Name = "Product 9",
                    Description = "Product 9 Description",
                    Value = 9,
                    PurchaseOrderId = 3
                },
                new Product
                {
                    Id = 10,
                    Name = "Product 10",
                    Description = "Product 10 Description",
                    Value = 10,
                    PurchaseOrderId = 3
                },
                new Product
                {
                    Id = 11,
                    Name = "Product 11",
                    Description = "Product 11 Description",
                    Value = 11,
                    PurchaseOrderId = 3
                },
                new Product
                {
                    Id = 12,
                    Name = "Product 12",
                    Description = "Product 12 Description",
                    Value = 12,
                    PurchaseOrderId = 4
                },
                new Product
                {
                    Id = 13,
                    Name = "Product 13",
                    Description = "Product 13 Description",
                    Value = 13,
                    PurchaseOrderId = 4
                },
                new Product
                {
                    Id = 14,
                    Name = "Product 14",
                    Description = "Product 14 Description",
                    Value = 14,
                    PurchaseOrderId = 4
                },
                new Product
                {
                    Id = 15,
                    Name = "Product 15",
                    Description = "Product 15 Description",
                    Value = 15,
                    PurchaseOrderId = 4
                }
            );
        }
    }
}
