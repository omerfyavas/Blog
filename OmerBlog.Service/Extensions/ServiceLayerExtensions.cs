using Microsoft.Extensions.DependencyInjection;
using OmerBlog.Service.Services.Abstractions;
using OmerBlog.Service.Services.Concrete;

namespace OmerBlog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            services.AddScoped< IArticleService, ArticleService>();
            return services;
        }
    }

}

