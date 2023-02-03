using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using OmerBlog.Data.Repositories.Abstractions;
using OmerBlog.Data.Repositories.Concretes;
using OmerBlog.Data.Context;
using Microsoft.EntityFrameworkCore;
using OmerBlog.Data.UnitOfWorks;

namespace OmerBlog.Data.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)

        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>(); 
            return services;
        }
    }
}
