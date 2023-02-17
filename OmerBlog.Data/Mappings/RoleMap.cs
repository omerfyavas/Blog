using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OmerBlog.Entity.Entities;

namespace OmerBlog.Data.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasKey(r => r.Id);

            builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

            builder.ToTable("AspNetRoles");

            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            builder.Property(u => u.Name).HasMaxLength(256);
            builder.Property(u => u.NormalizedName).HasMaxLength(256);

            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.HasData(new AppRole
            {
                Id = Guid.Parse("E8D824BF-1C1A-4D30-885D-8CCF1360B8A8"),
                Name = "Superadmin",
                NormalizedName = "SUPERADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString(),

            },
            new AppRole
            {
                Id = Guid.Parse("0A7E87F3-9105-4654-BC1B-36E4A13CDFB5"),
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            },
            new AppRole
            {
                Id = Guid.Parse("2C4FD2EA-574E-4454-9785-94806C1A3A0F"),
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = Guid.NewGuid().ToString(),

            });


        }
    }
}
