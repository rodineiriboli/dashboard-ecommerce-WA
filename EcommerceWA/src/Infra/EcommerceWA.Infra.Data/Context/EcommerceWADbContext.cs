using EcommerceWA.Domain.Entities;
using EcommerceWA.Infra.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWA.Infra.Data.Context
{
    public class EcommerceWADbContext : DbContext
    {
        public EcommerceWADbContext(DbContextOptions<EcommerceWADbContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<DeliveryTeam> DeliveryTeam { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new DeliveryTeamConfiguration());
            builder.ApplyConfiguration(new PurchaseOrderConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
