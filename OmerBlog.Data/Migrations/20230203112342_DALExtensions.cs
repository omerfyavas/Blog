using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OmerBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DalExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("ad9180be-0847-4952-bb2c-34a21a08063f"), "Admin", new DateTime(2023, 2, 3, 14, 23, 42, 155, DateTimeKind.Local).AddTicks(9582), null, null, false, null, null, "Deneme Makale" },
                    { new Guid("f1c22792-4f93-453e-8a7c-b5533703209f"), "Admin", new DateTime(2023, 2, 3, 14, 23, 42, 155, DateTimeKind.Local).AddTicks(9574), null, null, false, null, null, "Deneme Makale" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "FileName", "FileType", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { new Guid("5cb0d171-8303-4748-bece-fd0e1b7f86a4"), "Admin", new DateTime(2023, 2, 3, 14, 23, 42, 155, DateTimeKind.Local).AddTicks(9794), null, null, "image/testimage", "Jpg/Jpeg", null, false, null, null },
                    { new Guid("72ddadcc-3ad8-4883-8ffa-2265c5c9263b"), "Admin", new DateTime(2023, 2, 3, 14, 23, 42, 155, DateTimeKind.Local).AddTicks(9799), null, null, "image/testimage", "png", null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedOn", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("76ba3999-be44-48f1-8cbd-f787b2aa8acf"), new Guid("ad9180be-0847-4952-bb2c-34a21a08063f"), "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin", new DateTime(2023, 2, 3, 14, 23, 42, 155, DateTimeKind.Local).AddTicks(9154), null, null, new Guid("72ddadcc-3ad8-4883-8ffa-2265c5c9263b"), false, null, null, "Why do we use it?", 15 },
                    { new Guid("a4bc51cb-3e4d-4606-a476-ff307daecf57"), new Guid("4f8692b2-50ee-4efb-b736-b02cf34bff58"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum", "Admin", new DateTime(2023, 2, 3, 14, 23, 42, 155, DateTimeKind.Local).AddTicks(9144), null, null, new Guid("5cb0d171-8303-4748-bece-fd0e1b7f86a4"), false, null, null, "What is Lorem Ipsum?", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("76ba3999-be44-48f1-8cbd-f787b2aa8acf"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a4bc51cb-3e4d-4606-a476-ff307daecf57"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1c22792-4f93-453e-8a7c-b5533703209f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad9180be-0847-4952-bb2c-34a21a08063f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5cb0d171-8303-4748-bece-fd0e1b7f86a4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("72ddadcc-3ad8-4883-8ffa-2265c5c9263b"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
