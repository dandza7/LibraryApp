using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class BookIdInRentedBookMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentedBooks_Books_UserId",
                table: "RentedBooks");

            migrationBuilder.AddColumn<long>(
                name: "BookId",
                table: "RentedBooks",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1360), new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1369), new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1374), new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1159), new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1213), new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1220), new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1225), new DateTime(2023, 2, 27, 12, 57, 23, 220, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 57, 22, 493, DateTimeKind.Local).AddTicks(1930), new DateTime(2023, 2, 27, 12, 57, 22, 493, DateTimeKind.Local).AddTicks(1970), "E1BB34D88E6C660FECFCDCEB783743F3C2D2CFDCFFF6719CBF9814AB1337356469723F830081622FA6C4AE7601F7D66F543990B775023A253673E9D59202C2D7", new byte[] { 204, 81, 216, 242, 144, 181, 39, 37, 229, 44, 146, 187, 40, 21, 20, 254, 40, 173, 63, 220, 114, 31, 115, 212, 224, 89, 208, 71, 130, 39, 196, 38, 161, 221, 154, 193, 188, 184, 173, 55, 32, 66, 143, 13, 230, 163, 236, 39, 201, 74, 89, 29, 183, 135, 133, 133, 115, 196, 162, 220, 167, 138, 224, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 57, 22, 732, DateTimeKind.Local).AddTicks(7157), new DateTime(2023, 2, 27, 12, 57, 22, 732, DateTimeKind.Local).AddTicks(7202), "F7E0B7C00F782D52DA5EBB8B41597417740372DCA745EEE826B1035C3C6F130AD8917431595ED5A8BC0F6AEFCA201FB9EF9897F6F1448F8931BD010C2F4456C9", new byte[] { 100, 189, 211, 152, 63, 167, 27, 91, 10, 73, 92, 110, 133, 78, 46, 25, 4, 191, 3, 25, 120, 236, 49, 99, 65, 105, 107, 135, 59, 22, 60, 61, 176, 216, 114, 96, 173, 222, 119, 247, 44, 9, 3, 3, 104, 9, 95, 47, 185, 72, 19, 97, 200, 8, 112, 46, 140, 102, 46, 102, 245, 203, 154, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 57, 22, 975, DateTimeKind.Local).AddTicks(7000), new DateTime(2023, 2, 27, 12, 57, 22, 975, DateTimeKind.Local).AddTicks(7042), "5574CCE6AB67D26FB3F99667E9A6F08C653690E1F9B20E67C3CFC71678B8981D8F5107FB3E29CFB4F2C0DBA24781B937C342DA2A4CFDB92028157A636BA5FC79", new byte[] { 103, 26, 147, 192, 138, 166, 189, 221, 158, 146, 152, 65, 186, 210, 152, 76, 150, 82, 161, 7, 243, 119, 185, 128, 28, 194, 31, 240, 209, 149, 231, 219, 66, 72, 16, 83, 195, 242, 120, 239, 73, 117, 130, 255, 8, 137, 158, 61, 234, 84, 58, 229, 95, 0, 191, 2, 190, 60, 69, 84, 252, 209, 157, 65 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 57, 23, 219, DateTimeKind.Local).AddTicks(9916), new DateTime(2023, 2, 27, 12, 57, 23, 219, DateTimeKind.Local).AddTicks(9959), "2C47D28F7C679412276F215C3769FEEC98CC2CED79D1792BD9EC392F55A6F6BDF02C6FB26FE9790FDA9FF0B5E5E6755786B032E2DB102C62432D174B50502005", new byte[] { 117, 58, 142, 152, 74, 37, 81, 116, 33, 1, 221, 23, 37, 71, 159, 42, 98, 166, 10, 160, 132, 35, 1, 186, 160, 148, 135, 25, 240, 223, 192, 43, 35, 177, 201, 246, 195, 135, 125, 113, 37, 157, 208, 68, 241, 215, 212, 144, 159, 47, 47, 48, 80, 209, 245, 17, 23, 210, 242, 123, 140, 175, 165, 206 } });

            migrationBuilder.CreateIndex(
                name: "IX_RentedBooks_BookId",
                table: "RentedBooks",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentedBooks_Books_BookId",
                table: "RentedBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentedBooks_Books_BookId",
                table: "RentedBooks");

            migrationBuilder.DropIndex(
                name: "IX_RentedBooks_BookId",
                table: "RentedBooks");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "RentedBooks");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(7469), new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(7478), new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(7483), new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(7080), new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(7320), new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(7327), new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(7331), new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 4, 55, 801, DateTimeKind.Local).AddTicks(5197), new DateTime(2023, 2, 27, 12, 4, 55, 801, DateTimeKind.Local).AddTicks(5233), "B8D9D8A0A7FACE7DD3DBD150A3D6066F48C15CF9838097559CB527E147A6D73CFFD3895155736B4C48721A3C431E202AD6365B8AC9B495E670A3D0053208A161", new byte[] { 220, 143, 86, 231, 98, 46, 74, 204, 121, 220, 170, 154, 33, 162, 51, 85, 49, 64, 52, 21, 61, 226, 135, 7, 211, 27, 0, 83, 12, 53, 250, 53, 182, 254, 150, 128, 102, 24, 95, 176, 51, 117, 113, 69, 43, 108, 133, 20, 220, 240, 206, 20, 91, 253, 163, 228, 130, 248, 230, 91, 83, 132, 58, 123 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 4, 56, 25, DateTimeKind.Local).AddTicks(2718), new DateTime(2023, 2, 27, 12, 4, 56, 25, DateTimeKind.Local).AddTicks(2754), "452FEC383B6B5438A288CBF43C0A4BFC18C64A5884A8ED6F23EF945FDB140F2F5B549938783F54492CA64743CAFF16EB4AB8E950A47B8914E7580E8314C1046F", new byte[] { 131, 227, 117, 184, 235, 174, 101, 129, 188, 249, 208, 200, 208, 66, 240, 87, 246, 32, 112, 221, 184, 29, 75, 135, 56, 215, 75, 248, 120, 18, 248, 108, 46, 129, 131, 89, 196, 221, 108, 120, 235, 189, 35, 71, 217, 9, 46, 57, 171, 209, 251, 185, 164, 133, 248, 136, 203, 124, 19, 16, 5, 224, 37, 47 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 4, 56, 244, DateTimeKind.Local).AddTicks(964), new DateTime(2023, 2, 27, 12, 4, 56, 244, DateTimeKind.Local).AddTicks(1001), "2A6605E0702086EB2EEB6BBE5FA72F7C613F86CE8BC896AC6A8F1C9246AFA6479659B73BBE65D93855FC45AEFD3FAC7E7238AF022737A24A156E0C0640EAFE79", new byte[] { 202, 229, 179, 4, 89, 6, 59, 77, 162, 94, 38, 117, 224, 108, 21, 121, 153, 192, 24, 18, 151, 235, 61, 167, 43, 118, 163, 223, 255, 230, 199, 161, 170, 102, 161, 132, 248, 84, 65, 200, 251, 102, 107, 230, 51, 19, 41, 185, 208, 213, 10, 24, 167, 209, 52, 224, 55, 13, 134, 84, 161, 214, 66, 46 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(5832), new DateTime(2023, 2, 27, 12, 4, 56, 461, DateTimeKind.Local).AddTicks(5868), "FD5EE443F698A6BCB52C2124A07198B0369FD9E4E343EC5E17C3A2E764F1167A3B1890160CFF6C2B89414B5985342E141B2A57BE80FC986EE1C3777F5A8C3E42", new byte[] { 27, 198, 60, 78, 108, 46, 4, 186, 75, 50, 104, 213, 154, 92, 0, 61, 56, 179, 25, 73, 35, 97, 243, 194, 48, 61, 214, 179, 28, 103, 17, 140, 72, 50, 175, 214, 84, 174, 116, 87, 133, 58, 186, 6, 90, 231, 90, 157, 241, 140, 32, 46, 104, 159, 107, 169, 46, 28, 101, 130, 175, 245, 195, 224 } });

            migrationBuilder.AddForeignKey(
                name: "FK_RentedBooks_Books_UserId",
                table: "RentedBooks",
                column: "UserId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
