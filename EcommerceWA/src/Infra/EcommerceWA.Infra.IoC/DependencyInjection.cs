using EcommerceWA.Application.Interfaces;
using EcommerceWA.Application.Services;
using EcommerceWA.Domain.Interfaces;
using EcommerceWA.Infra.Data.Context;
using EcommerceWA.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EcommerceWA.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraStructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EcommerceWADbContext>(options =>
                options.UseMySQL(
                    configuration.GetConnectionString("DefaultConnection"),
                    x => x.MigrationsAssembly(typeof(EcommerceWADbContext)
                        .Assembly.FullName)));

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IPurchaseOrderService, PurchaseOrderService>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IPurchaseOrderRepository, PurchaseOrderRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
