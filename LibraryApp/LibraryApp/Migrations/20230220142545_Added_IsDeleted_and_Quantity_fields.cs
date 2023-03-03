using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsDeletedandQuantityfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Authors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "IsDeleted", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8419), false, new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "IsDeleted", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8424), false, new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "IsDeleted", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8428), false, new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "IsDeleted", "ModifiedDate", "Quantity" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8297), false, new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8303), 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "IsDeleted", "ModifiedDate", "Quantity" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8320), false, new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8326), 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "IsDeleted", "ModifiedDate", "Quantity" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8387), false, new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8388), 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "IsDeleted", "ModifiedDate", "Quantity" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8390), false, new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8391), 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "IsDeleted", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 44, 755, DateTimeKind.Local).AddTicks(663), false, new DateTime(2023, 2, 20, 15, 25, 44, 755, DateTimeKind.Local).AddTicks(725), "E21AE9571C574BC02C4FB39302DD36C5897E3B33C8DFF6431F397C26D5FFE2650A1ED9C833D429F9EB432FE6D08B4CAB28B3342C5036298BC9F394E30E8B898F", new byte[] { 42, 66, 95, 91, 144, 77, 164, 46, 120, 239, 120, 176, 95, 53, 229, 254, 249, 99, 77, 82, 158, 38, 117, 44, 90, 15, 60, 46, 229, 4, 68, 44, 227, 101, 207, 45, 11, 239, 170, 37, 20, 14, 193, 227, 190, 135, 57, 105, 92, 167, 130, 222, 174, 119, 14, 15, 62, 141, 11, 177, 106, 8, 235, 203 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "IsDeleted", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 44, 926, DateTimeKind.Local).AddTicks(3979), false, new DateTime(2023, 2, 20, 15, 25, 44, 926, DateTimeKind.Local).AddTicks(4024), "CBB22A04C2D39465558C31CC31E77561FEE617C0FBD05A37A12606F456C1B7A0FAE7D3222C9A3FD3ED88C8920ACAB06DE516752941A480073295E85DA1CCC215", new byte[] { 243, 41, 225, 35, 2, 69, 6, 16, 241, 38, 105, 243, 202, 207, 126, 8, 56, 179, 81, 196, 99, 39, 170, 55, 148, 191, 8, 169, 114, 113, 91, 166, 173, 154, 216, 163, 180, 204, 228, 59, 112, 171, 125, 83, 100, 228, 158, 171, 127, 105, 134, 81, 106, 145, 41, 43, 32, 127, 22, 55, 125, 68, 19, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "IsDeleted", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 99, DateTimeKind.Local).AddTicks(5732), false, new DateTime(2023, 2, 20, 15, 25, 45, 99, DateTimeKind.Local).AddTicks(5764), "B0B384989BD6078009003B7A0C24EB6301F9AC3246CC7CA261C40A976DE3ED0B9692B581EF7A1F61D683E63ACAD2B473C4076AA923CE44E863DAC57C9AA89E63", new byte[] { 144, 31, 196, 219, 153, 232, 189, 177, 33, 143, 244, 162, 79, 71, 129, 17, 219, 132, 71, 64, 189, 41, 216, 247, 217, 255, 199, 80, 219, 49, 194, 235, 95, 4, 140, 178, 84, 3, 11, 107, 211, 143, 6, 70, 131, 165, 93, 201, 191, 49, 253, 100, 229, 27, 10, 230, 159, 156, 108, 105, 156, 46, 149, 23 } });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CreatedDate", "Email", "FirstName", "IsDeleted", "LastName", "ModifiedDate", "Password", "Role", "Salt" },
                values: new object[] { 4L, null, new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(7863), "kikimaher@gmail.com", "Kristijan", true, "Trnjanac", new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(7893), "BBC09AA7C466013AFD04A7C06296DAB7E78FDB5118EAB4559FF1862BF03BBC7589CEBEC1F371FAC8E74072C6C900DD9B9B5033D33EB65562D9B5E0CC9289C177", "USER", new byte[] { 98, 198, 36, 157, 106, 237, 155, 171, 50, 7, 87, 167, 208, 5, 254, 64, 249, 66, 231, 211, 149, 28, 226, 243, 229, 232, 133, 91, 101, 163, 213, 39, 159, 0, 97, 197, 156, 110, 43, 152, 180, 112, 25, 7, 11, 129, 87, 237, 195, 179, 63, 162, 39, 215, 50, 172, 98, 205, 40, 136, 54, 248, 39, 222 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Authors");

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
    }
}
