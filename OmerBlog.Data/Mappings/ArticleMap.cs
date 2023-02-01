using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Category = new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Deneme Makale",
                    CreatedBy = "Admin",
                    CreatedOn = DateTime.Now,
                    IsDeleted = false,
                },
                Image = new Image
                {
                    Id = Guid.NewGuid(),
                    FileName = "image/testimage",
                    FileType = "Jpg/Jpeg",
                    CreatedBy = "Admin",
                    CreatedOn = DateTime.Now,
                    IsDeleted = false,

                },
                CreatedBy = "Admin",
                CreatedOn = DateTime.Now,

            },
                new Article
                {
                    Id = Guid.NewGuid(),
                    Title = "Why do we use it?",
                    Content = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                    ViewCount = 15,
                    Category = new Category
                    {
                        Id = Guid.NewGuid(),
                        Name = "Deneme Makale",
                        CreatedBy = "Admin",
                        CreatedOn = DateTime.Now,
                        IsDeleted = false,
                    },
                    Image = new Image
                    {
                        Id = Guid.NewGuid(),
                        FileName = "image/testimage",
                        FileType = "png",
                        CreatedBy = "Admin",
                        CreatedOn = DateTime.Now,
                        IsDeleted = false,

                    },
                    CreatedBy = "Admin",
                    CreatedOn = DateTime.Now,


                }
                );


        }
    }
}
