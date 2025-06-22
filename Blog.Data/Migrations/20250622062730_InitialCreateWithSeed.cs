using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateWithSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop existing tables if they exist
            migrationBuilder.Sql("DROP TABLE IF EXISTS \"Articles\" CASCADE;");
            migrationBuilder.Sql("DROP TABLE IF EXISTS \"Categories\" CASCADE;");
            migrationBuilder.Sql("DROP TABLE IF EXISTS \"Images\" CASCADE;");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    fileName = table.Column<string>(type: "text", nullable: false),
                    FileType = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    ViewCount = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    ImageId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    DeletedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), "Admin Test", new DateTime(2025, 6, 22, 6, 27, 30, 77, DateTimeKind.Utc).AddTicks(5960), null, null, false, null, null, "ASP.NET" },
                    { new Guid("fd2060b6-a32f-46b6-94d4-a3ad14b6b372"), "Admin Test", new DateTime(2025, 6, 22, 6, 27, 30, 77, DateTimeKind.Utc).AddTicks(5970), null, null, false, null, null, "ASP.NET 2" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate", "fileName" },
                values: new object[,]
                {
                    { new Guid("0d804ae8-17d6-470e-966d-3d82c4f46662"), "Admin Test", new DateTime(2025, 6, 22, 6, 27, 30, 77, DateTimeKind.Utc).AddTicks(6350), null, null, "jpg", false, null, null, "images/testimage" },
                    { new Guid("840a754b-f051-45f3-90c5-61d1e249d5a5"), "Admin Test", new DateTime(2025, 6, 22, 6, 27, 30, 77, DateTimeKind.Utc).AddTicks(6350), null, null, "jpg", false, null, null, "images/testimage" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), "Asp.NET Core Core Deneme İçerik 1", "Admin test", new DateTime(2025, 6, 22, 6, 27, 30, 77, DateTimeKind.Utc).AddTicks(5420), null, null, new Guid("0d804ae8-17d6-470e-966d-3d82c4f46662"), false, null, null, "Asp.NET Core Core Deneme Makalesi 1", 2 },
                    { new Guid("b1c2d3e4-f5a6-7890-bcde-ef1234567890"), new Guid("fd2060b6-a32f-46b6-94d4-a3ad14b6b372"), "Asp.NET Core Core Deneme İçerik 2", "Admin test", new DateTime(2025, 6, 22, 6, 27, 30, 77, DateTimeKind.Utc).AddTicks(5420), null, null, new Guid("840a754b-f051-45f3-90c5-61d1e249d5a5"), false, null, null, "Asp.NET Core Core Deneme Makalesi 2", 24 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ImageId",
                table: "Articles",
                column: "ImageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
