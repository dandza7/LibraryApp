using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddHashingForDummyUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(7221), new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(7226), new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(7229), new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(7022), new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(7033), new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(7098), new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(7107), new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 13, 10, 16, 26, 581, DateTimeKind.Local).AddTicks(2140), new DateTime(2023, 2, 13, 10, 16, 26, 581, DateTimeKind.Local).AddTicks(2183), "4BD0DF794662D3B44E7346E269B403DF6C4D27D8B63DB55E0F05159E4F38954CFBDAAA9D6C6194A9FC03E20AFFF882A138E3683B43C11271D7FDA175EEB9AFF4", new byte[] { 183, 72, 44, 218, 119, 41, 107, 218, 225, 27, 36, 84, 220, 139, 131, 62, 171, 58, 14, 232, 109, 70, 243, 128, 186, 62, 156, 206, 107, 222, 152, 52, 148, 176, 251, 163, 108, 63, 85, 67, 104, 98, 69, 199, 18, 98, 109, 71, 37, 21, 88, 94, 106, 7, 226, 28, 15, 166, 204, 234, 123, 209, 133, 61 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 13, 10, 16, 26, 751, DateTimeKind.Local).AddTicks(4496), new DateTime(2023, 2, 13, 10, 16, 26, 751, DateTimeKind.Local).AddTicks(4536), "D265FA577E8B746B53B658D90ADB1B795F6E6DCA12F24ADF05A4BD8A39780664C0A49C38EFA54D925F49521F0390F67288CBB8E1A4E21088B26134950934B492", new byte[] { 61, 73, 173, 36, 0, 110, 221, 243, 156, 84, 72, 90, 34, 34, 107, 112, 69, 65, 185, 67, 98, 253, 109, 249, 40, 90, 98, 56, 233, 0, 193, 241, 208, 245, 8, 104, 134, 254, 23, 161, 18, 223, 81, 188, 71, 119, 240, 78, 19, 217, 195, 228, 142, 60, 239, 3, 206, 88, 202, 239, 154, 67, 91, 2 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(6497), new DateTime(2023, 2, 13, 10, 16, 26, 924, DateTimeKind.Local).AddTicks(6525), "2FACFF9DAEBE8A971500660A8E74E5532FFEB1CC47D560FBE4D9E33C7B6D3BDE9F65DD04E2931C573BD71860A2591E7F3C27414C2443148B79308CB507231E10", new byte[] { 13, 47, 185, 18, 104, 174, 141, 117, 188, 22, 98, 146, 88, 79, 31, 74, 228, 180, 168, 161, 143, 204, 165, 60, 25, 145, 132, 228, 116, 89, 162, 216, 180, 66, 195, 176, 118, 119, 96, 20, 58, 103, 113, 82, 43, 36, 86, 194, 223, 235, 205, 11, 41, 88, 244, 240, 41, 191, 118, 186, 232, 216, 127, 255 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9112), new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9141), "123", new byte[] { 136, 206, 87, 223, 204, 1, 250, 53, 117, 37, 133, 48, 33, 231, 242, 89, 68, 84, 62, 152, 52, 97, 235, 251, 89, 7, 173, 31, 116, 217, 25, 178, 219, 38, 92, 151, 100, 196, 237, 25, 110, 125, 2, 69, 137, 51, 24, 130, 9, 124, 133, 207, 91, 156, 95, 170, 133, 219, 106, 113, 202, 29, 118, 8 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9238), new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9239), "123", new byte[] { 72, 2, 103, 91, 128, 251, 231, 235, 153, 71, 124, 146, 110, 248, 173, 11, 203, 161, 64, 3, 101, 128, 53, 251, 138, 180, 37, 227, 186, 123, 23, 204, 232, 97, 123, 104, 18, 188, 197, 127, 175, 11, 169, 123, 10, 196, 2, 224, 106, 139, 81, 9, 246, 107, 198, 175, 7, 33, 49, 25, 73, 147, 255, 44 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9244), new DateTime(2023, 2, 13, 9, 59, 12, 208, DateTimeKind.Local).AddTicks(9245), "123", new byte[] { 132, 49, 5, 156, 199, 38, 138, 214, 163, 79, 158, 197, 225, 163, 175, 7, 44, 166, 130, 223, 30, 50, 13, 112, 103, 52, 167, 39, 46, 61, 70, 82, 119, 138, 20, 104, 125, 150, 86, 99, 25, 107, 35, 199, 56, 48, 131, 187, 115, 122, 19, 63, 26, 123, 181, 208, 244, 157, 22, 221, 101, 75, 158, 246 } });
        }
    }
}
