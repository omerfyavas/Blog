using Microsoft.Extensions.DependencyInjection;
using OmerBlog.Service.Services.Abstractions;
using OmerBlog.Service.Services.Concrete;
using System.Reflection;

namespace OmerBlog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService, ArticleService>();

            services.AddAutoMapper(assembly);
            return services;
        }
    }

}

