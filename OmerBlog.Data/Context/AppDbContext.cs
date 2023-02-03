using Microsoft.EntityFrameworkCore;
using OmerBlog.Entity.Entities;
using System.Reflection;

namespace OmerBlog.Data.Context
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Category> Categories { get; set; } 

        public DbSet<Image>Images { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
        } 


    }
}
