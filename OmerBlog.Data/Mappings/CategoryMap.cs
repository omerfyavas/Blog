using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OmerBlog.Entity.Entities;

namespace OmerBlog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {

                Name = "Deneme Makale",
                CreatedBy = "Admin",
                CreatedOn = DateTime.Now,
                IsDeleted = false,
            },
            new Category
            {
                Id = Guid.Parse("AD9180BE-0847-4952-BB2C-34A21A08063F"),
                Name = "Deneme Makale",
                CreatedBy = "Admin",
                CreatedOn = DateTime.Now,
                IsDeleted = false,
            });
        }
    }
}
