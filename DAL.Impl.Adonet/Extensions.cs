using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.Impl.Adonet
{
    public static class Extensions
    {
        public static IServiceCollection RegisterAdoNetImplementation(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
