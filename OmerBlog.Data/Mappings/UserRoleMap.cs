using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OmerBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmerBlog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });


            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("01DC6A08-7A73-4FC6-8368-D57C713B6825"),
                RoleId = Guid.Parse("E8D824BF-1C1A-4D30-885D-8CCF1360B8A8"),

            },
            new AppUserRole
            {
                UserId = Guid.Parse("295AE0FD-D8E2-4BC5-BC90-361C1B6668E4"),
                RoleId = Guid.Parse("0A7E87F3-9105-4654-BC1B-36E4A13CDFB5"),
            }
            );
        }
    }
}
