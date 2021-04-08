using DAL.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.Impl.Ef
{
    public static class Extensions
    {
        public static IServiceCollection RegisterEfCoreImplementation(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShopContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ShopContext")));
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
            return services;
        }
    }
}
