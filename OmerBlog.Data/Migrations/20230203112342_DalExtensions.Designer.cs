// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OmerBlog.Data.Context;

#nullable disable

namespace OmerBlog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230203112342_DalExtensions")]
    partial class DalExtensions
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OmerBlog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a4bc51cb-3e4d-4606-a476-ff307daecf57"),
                            CategoryId = new Guid("4f8692b2-50ee-4efb-b736-b02cf34bff58"),
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                            CreatedBy = "Admin",
                            CreatedOn = new DateTime(2023, 2, 3, 14, 23, 42, 155, DateTimeKind.Local).AddTicks(9144),
                            ImageId = new Guid("5cb0d171-8303-4748-bece-fd0e1b7f86a4"),
                            IsDeleted = false,
                            Title = "What is Lorem Ipsum?",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("76ba3999-be44-48f1-8cbd-f787b2aa8acf"),
                            CategoryId = new Guid("ad9180be-0847-4952-bb2c-34a21a08063f"),
                            Content = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                            CreatedBy = "Admin",
                            CreatedOn = new DateTime(2023, 2, 3, 14, 23, 42, 155, DateTimeKind.Local).AddTicks(9154),
                            ImageId = new Guid("72ddadcc-3ad8-4883-8ffa-2265c5c9263b"),
                            IsDeleted = false,
                            Title = "Why do we use it?",
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("OmerBlog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f1c22792-4f93-453e-8a7c-b5533703209f"),
                            CreatedBy = "Admin",
                            CreatedOn = new DateTime(2023, 2, 3, 14, 23, 42, 155, DateTimeKind.Local).AddTicks(9574),
                            IsDeleted = false,
                            Name = "Deneme Makale"
                        },
                        new
                        {
                            Id = new Guid("ad9180be-0847-4952-bb2c-34a21a08063f"),
                            CreatedBy = "Admin",
                            CreatedOn = new DateTime(2023, 2, 3, 14, 23, 42, 155, DateTimeKind.Local).AddTicks(9582),
                            IsDeleted = false,
                            Name = "Deneme Makale"
                        });
                });

            modelBuilder.Entity("OmerBlog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5cb0d171-8303-4748-bece-fd0e1b7f86a4"),
                            CreatedBy = "Admin",
                            CreatedOn = new DateTime(2023, 2, 3, 14, 23, 42, 155, DateTimeKind.Local).AddTicks(9794),
                            FileName = "image/testimage",
                            FileType = "Jpg/Jpeg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("72ddadcc-3ad8-4883-8ffa-2265c5c9263b"),
                            CreatedBy = "Admin",
                            CreatedOn = new DateTime(2023, 2, 3, 14, 23, 42, 155, DateTimeKind.Local).AddTicks(9799),
                            FileName = "image/testimage",
                            FileType = "png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("OmerBlog.Entity.Entities.Article", b =>
                {
                    b.HasOne("OmerBlog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OmerBlog.Entity.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("OmerBlog.Entity.Entities.Image", b =>
                {
                    b.HasOne("OmerBlog.Entity.Entities.Image", null)
                        .WithMany("Images")
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("OmerBlog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("OmerBlog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
