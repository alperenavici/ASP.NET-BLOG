using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserCreated2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 9, 54, 37, 265, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b1c2d3e4-f5a6-7890-bcde-ef1234567890"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 9, 54, 37, 265, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("051a9ccf-5827-47a5-88f2-5f26e2f35d69"),
                column: "ConcurrencyStamp",
                value: "d762092f-af79-4dff-a0c2-ca391e3df05c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c1fef4f-dfe2-4420-bd38-b38c014a9531"),
                column: "ConcurrencyStamp",
                value: "81715315-24d5-4de7-88a1-7d2bb57cd178");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("97ad219e-93c8-4015-8679-2ff4bd481e04"),
                column: "ConcurrencyStamp",
                value: "e8928330-35c9-4759-87f6-3f4a9ff45be5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b72f6ee-8423-4b3f-b323-24b405cf6514"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1de57109-30bd-4e81-99ef-efed0b2a4e17", "AQAAAAIAAYagAAAAEAYUxP2p3I1/r46MENQ1PdwuMr/VCF7s99NPFNpYkNvfwbnIbGrj6PsQ3ft57CaI/w==", "9542c103-fe1e-47e7-a983-449ab8155ac4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fffb1403-e7d7-4c8b-858e-25bcb97d7e47"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d837f996-df93-4c50-b706-1cafdb0a3ddf", "AQAAAAIAAYagAAAAEOqQtjEdfXrECuNTQiKsOXU8sJCd9ppP9Lj4bBJiCR2KlwKiExbn6kEfXj6oiUyO7A==", "3b0edaf2-925f-45a3-a3fb-18ed149760e5" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 9, 54, 37, 265, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd2060b6-a32f-46b6-94d4-a3ad14b6b372"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 9, 54, 37, 265, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0d804ae8-17d6-470e-966d-3d82c4f46662"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 9, 54, 37, 265, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("840a754b-f051-45f3-90c5-61d1e249d5a5"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 9, 54, 37, 265, DateTimeKind.Utc).AddTicks(1910));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 9, 48, 11, 319, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b1c2d3e4-f5a6-7890-bcde-ef1234567890"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 9, 48, 11, 319, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("051a9ccf-5827-47a5-88f2-5f26e2f35d69"),
                column: "ConcurrencyStamp",
                value: "8d914932-db0f-4999-a763-ebd3db1f314e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c1fef4f-dfe2-4420-bd38-b38c014a9531"),
                column: "ConcurrencyStamp",
                value: "97a02f06-b7db-43af-8b0f-8bf742d56acc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("97ad219e-93c8-4015-8679-2ff4bd481e04"),
                column: "ConcurrencyStamp",
                value: "f15961fa-c533-488e-bc65-d61bd119f187");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b72f6ee-8423-4b3f-b323-24b405cf6514"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad187b1b-3e1c-4dcf-8e68-f5841222445a", "AQAAAAIAAYagAAAAEHS03DVpHluaNV3TGIRdgjeUh20tUKo3qe2KAkJWfN8tsLwglIPHCzy0PPV2x7QWZA==", "ecf107c6-14d5-44da-af51-ef7757907f95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fffb1403-e7d7-4c8b-858e-25bcb97d7e47"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b82fd64a-e0ed-4482-b6b4-bbcc4e7f5b49", "AQAAAAIAAYagAAAAEIsBbrrLrPU15NfzHfIYyleWC/3rJsZLNAdHEx/gFSDwX7on+yLz1I8jWcavqYJD2w==", "c291963a-0707-4072-a505-3c0cab7dd0f4" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 9, 48, 11, 319, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd2060b6-a32f-46b6-94d4-a3ad14b6b372"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 9, 48, 11, 319, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0d804ae8-17d6-470e-966d-3d82c4f46662"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 9, 48, 11, 319, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("840a754b-f051-45f3-90c5-61d1e249d5a5"),
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 9, 48, 11, 319, DateTimeKind.Utc).AddTicks(4490));
        }
    }
}
