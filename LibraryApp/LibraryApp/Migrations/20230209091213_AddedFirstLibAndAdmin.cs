using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedFirstLibAndAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 9, 10, 12, 13, 262, DateTimeKind.Local).AddTicks(4514), new DateTime(2023, 2, 9, 10, 12, 13, 262, DateTimeKind.Local).AddTicks(4545) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CreatedDate", "Email", "FirstName", "LastName", "ModifiedDate", "Password", "Role" },
                values: new object[,]
                {
                    { 2L, null, new DateTime(2023, 2, 9, 10, 12, 13, 262, DateTimeKind.Local).AddTicks(4559), "woox.gg@gmail.com", "Nikola", "Vukic", new DateTime(2023, 2, 9, 10, 12, 13, 262, DateTimeKind.Local).AddTicks(4560), "123", "LIBRARIAN" },
                    { 3L, null, new DateTime(2023, 2, 9, 10, 12, 13, 262, DateTimeKind.Local).AddTicks(4563), "djokeen@gmail.com", "Djordje", "Rasic", new DateTime(2023, 2, 9, 10, 12, 13, 262, DateTimeKind.Local).AddTicks(4564), "123", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 9, 9, 36, 40, 583, DateTimeKind.Local).AddTicks(1042), new DateTime(2023, 2, 9, 9, 36, 40, 583, DateTimeKind.Local).AddTicks(1073) });
        }
    }
}
