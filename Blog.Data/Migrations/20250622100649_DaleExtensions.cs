using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DaleExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 10, 6, 49, 365, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b1c2d3e4-f5a6-7890-bcde-ef1234567890"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 10, 6, 49, 365, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 10, 6, 49, 365, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd2060b6-a32f-46b6-94d4-a3ad14b6b372"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 10, 6, 49, 365, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0d804ae8-17d6-470e-966d-3d82c4f46662"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 10, 6, 49, 365, DateTimeKind.Utc).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("840a754b-f051-45f3-90c5-61d1e249d5a5"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 10, 6, 49, 365, DateTimeKind.Utc).AddTicks(2000));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 6, 27, 30, 77, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b1c2d3e4-f5a6-7890-bcde-ef1234567890"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 6, 27, 30, 77, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 6, 27, 30, 77, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd2060b6-a32f-46b6-94d4-a3ad14b6b372"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 6, 27, 30, 77, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0d804ae8-17d6-470e-966d-3d82c4f46662"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 6, 27, 30, 77, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("840a754b-f051-45f3-90c5-61d1e249d5a5"),
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 6, 27, 30, 77, DateTimeKind.Utc).AddTicks(6350));
        }
    }
}
