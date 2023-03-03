using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedAuthorsAndBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "FirstName", "LastName", "ModifiedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8630), "Ljubo", "Nedovic", new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8631) },
                    { 2L, new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8635), "Rade", "Doroslovacki", new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8636) },
                    { 3L, new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8639), "Damir", "Madjarevic", new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8640) }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CreatedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8607), new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8608), "Algebra Testovi" },
                    { 2L, new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8612), new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8613), "Algebra" },
                    { 3L, new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8615), new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8616), "Mehanika" },
                    { 4L, new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8618), new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8619), "Zbirka zadataka iz Mehanike" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8538), new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8590), new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8595), new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8596) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 9, 10, 34, 3, 197, DateTimeKind.Local).AddTicks(1548), new DateTime(2023, 2, 9, 10, 34, 3, 197, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 9, 10, 34, 3, 197, DateTimeKind.Local).AddTicks(1590), new DateTime(2023, 2, 9, 10, 34, 3, 197, DateTimeKind.Local).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 9, 10, 34, 3, 197, DateTimeKind.Local).AddTicks(1595), new DateTime(2023, 2, 9, 10, 34, 3, 197, DateTimeKind.Local).AddTicks(1597) });
        }
    }
}
