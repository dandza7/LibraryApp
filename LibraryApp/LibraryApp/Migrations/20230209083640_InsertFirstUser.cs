using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class InsertFirstUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Avatar",
                table: "Users",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CreatedDate", "Email", "FirstName", "LastName", "ModifiedDate", "Password", "Role" },
                values: new object[] { 1L, null, new DateTime(2023, 2, 9, 9, 36, 40, 583, DateTimeKind.Local).AddTicks(1042), "dane.m.12@gmail.com", "Dane", "Milisic", new DateTime(2023, 2, 9, 9, 36, 40, 583, DateTimeKind.Local).AddTicks(1073), "123", "USER" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Avatar",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);
        }
    }
}
