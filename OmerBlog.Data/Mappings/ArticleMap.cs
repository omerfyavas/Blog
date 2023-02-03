using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OmerBlog.Entity.Entities;

namespace OmerBlog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {

                Id = Guid.NewGuid(),
                Title = "What is Lorem Ipsum?",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                ViewCount = 15,
                CategoryId = Guid.Parse("{4F8692B2-50EE-4EFB-B736-B02CF34BFF58}"),
                ImageId = Guid.Parse("{5CB0D171-8303-4748-BECE-FD0E1B7F86A4}"),
                CreatedBy = "Admin",
                CreatedOn = DateTime.Now,
                IsDeleted = false,

            },
                new Article
                {
                    Id = Guid.NewGuid(),
                    Title = "Why do we use it?",
                    Content = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                    ViewCount = 15,
                    CategoryId = Guid.Parse("{AD9180BE-0847-4952-BB2C-34A21A08063F}"),
                    ImageId = Guid.Parse("{72DDADCC-3AD8-4883-8FFA-2265C5C9263B}"),
                    CreatedBy = "Admin",
                    CreatedOn = DateTime.Now,


                }
                );


        }
    }
}
