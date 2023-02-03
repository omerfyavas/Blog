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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("{5CB0D171-8303-4748-BECE-FD0E1B7F86A4}"),
                FileName = "image/testimage",
                FileType = "Jpg/Jpeg",
                CreatedBy = "Admin",
                CreatedOn = DateTime.Now,
                IsDeleted = false,

            },
            new Image
            {
                Id = Guid.Parse("{72DDADCC-3AD8-4883-8FFA-2265C5C9263B}"),
                FileName = "image/testimage",
                FileType = "png",
                CreatedBy = "Admin",
                CreatedOn = DateTime.Now,
                IsDeleted = false,

            });
        }
    }
}
