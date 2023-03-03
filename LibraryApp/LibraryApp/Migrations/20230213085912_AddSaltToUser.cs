using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSaltToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Salt",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9284), new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9317), new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9321), new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9261), new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9266), new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9269), new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9273), new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Salt" },
                values: new object[] { new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9112), new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9141), new byte[] { 136, 206, 87, 223, 204, 1, 250, 53, 117, 37, 133, 48, 33, 231, 242, 89, 68, 84, 62, 152, 52, 97, 235, 251, 89, 7, 173, 31, 116, 217, 25, 178, 219, 38, 92, 151, 100, 196, 237, 25, 110, 125, 2, 69, 137, 51, 24, 130, 9, 124, 133, 207, 91, 156, 95, 170, 133, 219, 106, 113, 202, 29, 118, 8 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Salt" },
                values: new object[] { new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9238), new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9239), new byte[] { 72, 2, 103, 91, 128, 251, 231, 235, 153, 71, 124, 146, 110, 248, 173, 11, 203, 161, 64, 3, 101, 128, 53, 251, 138, 180, 37, 227, 186, 123, 23, 204, 232, 97, 123, 104, 18, 188, 197, 127, 175, 11, 169, 123, 10, 196, 2, 224, 106, 139, 81, 9, 246, 107, 198, 175, 7, 33, 49, 25, 73, 147, 255, 44 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Salt" },
                values: new object[] { new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9244), new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9245), new byte[] { 132, 49, 5, 156, 199, 38, 138, 214, 163, 79, 158, 197, 225, 163, 175, 7, 44, 166, 130, 223, 30, 50, 13, 112, 103, 52, 167, 39, 46, 61, 70, 82, 119, 138, 20, 104, 125, 150, 86, 99, 25, 107, 35, 199, 56, 48, 131, 187, 115, 122, 19, 63, 26, 123, 181, 208, 244, 157, 22, 221, 101, 75, 158, 246 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8630), new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8635), new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8639), new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8607), new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8612), new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8615), new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8618), new DateTime(2023, 2, 9, 10, 46, 1, 9, DateTimeKind.Local).AddTicks(8619) });

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
    }
}
