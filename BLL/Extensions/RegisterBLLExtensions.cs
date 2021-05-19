using BLL.Implementations;
using BLL.Interfaces;
using BLL.MappingProfiles;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.Extensions
{
    public static class RegisterBLLExtensions
    {
        public static IServiceCollection RegisterBLL(this IServiceCollection services)
        {
            services.AddTransient<IArticleService, ArticleService>();
            services.AddTransient<IArticleInOrderService, ArticleInOrderService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IDescriptionInArticleService, DescriptionInArticleService>();
            services.AddTransient<IDescriptionService, DescriptionService>();
            services.AddAutoMapper(typeof(ArticleProfile).Assembly);
            return services;
        }
    }
}
