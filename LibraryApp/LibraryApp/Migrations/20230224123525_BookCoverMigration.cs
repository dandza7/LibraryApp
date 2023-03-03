using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class BookCoverMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Cover",
                table: "Books",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6848), new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6859), new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Cover", "CreatedDate", "ModifiedDate" },
                values: new object[] { null, new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6524), new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Cover", "CreatedDate", "ModifiedDate" },
                values: new object[] { null, new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6640), new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Cover", "CreatedDate", "ModifiedDate" },
                values: new object[] { null, new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6647), new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Cover", "CreatedDate", "ModifiedDate" },
                values: new object[] { null, new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6652), new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 35, 24, 471, DateTimeKind.Local).AddTicks(7268), new DateTime(2023, 2, 24, 13, 35, 24, 471, DateTimeKind.Local).AddTicks(7306), "DD1A4EF3E6D5DC0AC1F0173EF1499064F2C2F841E2420267FCD7BC4805307F0E8A34EE44F2E3193C1F6F967AC71406454BD3DED7C82C2FE9FA016FBC5B24B877", new byte[] { 109, 20, 185, 59, 47, 58, 44, 0, 107, 27, 59, 150, 90, 10, 172, 212, 157, 81, 88, 145, 125, 114, 99, 61, 235, 34, 3, 57, 190, 174, 37, 254, 50, 243, 36, 120, 83, 249, 29, 213, 135, 102, 195, 102, 88, 130, 90, 60, 171, 142, 59, 180, 129, 133, 177, 93, 198, 179, 184, 131, 21, 211, 38, 11 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 35, 24, 714, DateTimeKind.Local).AddTicks(716), new DateTime(2023, 2, 24, 13, 35, 24, 714, DateTimeKind.Local).AddTicks(752), "941C0F084FFA95B83897A024A5F781409639499C99EB54791A28929E3415FC40D0F697B9BF9371A4E9B8B54EFA601CC493F17B75D6F3893B0D191D6358581692", new byte[] { 248, 246, 77, 132, 31, 94, 151, 20, 134, 116, 178, 247, 216, 73, 175, 61, 234, 42, 116, 233, 114, 138, 115, 138, 233, 219, 137, 48, 73, 107, 39, 211, 229, 106, 11, 253, 16, 110, 193, 186, 239, 111, 1, 182, 108, 238, 32, 104, 136, 28, 249, 82, 156, 207, 202, 140, 155, 90, 92, 70, 159, 22, 71, 128 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 35, 24, 953, DateTimeKind.Local).AddTicks(8186), new DateTime(2023, 2, 24, 13, 35, 24, 953, DateTimeKind.Local).AddTicks(8222), "B1A27F2010A06F7C2FA28EC55D29E4AB9554A14C0681BA9CD8BF9EF8C62F4B9E7445D908B96856297CB58F7EB6461E8B2E81038F6A49FD6B94BD31CCB8A432C5", new byte[] { 2, 71, 53, 36, 231, 147, 189, 41, 203, 18, 50, 237, 95, 54, 251, 236, 192, 0, 239, 107, 1, 104, 85, 60, 237, 6, 125, 15, 139, 75, 202, 252, 51, 2, 241, 243, 78, 138, 197, 231, 110, 184, 187, 251, 33, 191, 58, 181, 55, 190, 36, 250, 206, 111, 60, 102, 8, 101, 73, 123, 122, 189, 106, 231 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(5218), new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(5259), "D152272ED537032D76A58771DDF11995DF2DF10E7197372D3A8060BA9270A1BCFDC55680AC79BD05A1EB1BE556B6F041E351C54927DBAF389CC74EBF16746D9D", new byte[] { 167, 7, 158, 58, 175, 92, 53, 199, 191, 110, 237, 93, 36, 107, 54, 143, 88, 108, 115, 27, 57, 13, 215, 29, 85, 129, 222, 53, 142, 41, 188, 26, 130, 75, 202, 101, 231, 251, 145, 248, 205, 204, 156, 240, 134, 242, 226, 19, 191, 159, 58, 138, 208, 96, 19, 97, 109, 101, 95, 149, 15, 224, 200, 25 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cover",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8419), new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8424), new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8428), new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8297), new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8320), new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8387), new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8390), new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 44, 755, DateTimeKind.Local).AddTicks(663), new DateTime(2023, 2, 20, 15, 25, 44, 755, DateTimeKind.Local).AddTicks(725), "E21AE9571C574BC02C4FB39302DD36C5897E3B33C8DFF6431F397C26D5FFE2650A1ED9C833D429F9EB432FE6D08B4CAB28B3342C5036298BC9F394E30E8B898F", new byte[] { 42, 66, 95, 91, 144, 77, 164, 46, 120, 239, 120, 176, 95, 53, 229, 254, 249, 99, 77, 82, 158, 38, 117, 44, 90, 15, 60, 46, 229, 4, 68, 44, 227, 101, 207, 45, 11, 239, 170, 37, 20, 14, 193, 227, 190, 135, 57, 105, 92, 167, 130, 222, 174, 119, 14, 15, 62, 141, 11, 177, 106, 8, 235, 203 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 44, 926, DateTimeKind.Local).AddTicks(3979), new DateTime(2023, 2, 20, 15, 25, 44, 926, DateTimeKind.Local).AddTicks(4024), "CBB22A04C2D39465558C31CC31E77561FEE617C0FBD05A37A12606F456C1B7A0FAE7D3222C9A3FD3ED88C8920ACAB06DE516752941A480073295E85DA1CCC215", new byte[] { 243, 41, 225, 35, 2, 69, 6, 16, 241, 38, 105, 243, 202, 207, 126, 8, 56, 179, 81, 196, 99, 39, 170, 55, 148, 191, 8, 169, 114, 113, 91, 166, 173, 154, 216, 163, 180, 204, 228, 59, 112, 171, 125, 83, 100, 228, 158, 171, 127, 105, 134, 81, 106, 145, 41, 43, 32, 127, 22, 55, 125, 68, 19, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 99, DateTimeKind.Local).AddTicks(5732), new DateTime(2023, 2, 20, 15, 25, 45, 99, DateTimeKind.Local).AddTicks(5764), "B0B384989BD6078009003B7A0C24EB6301F9AC3246CC7CA261C40A976DE3ED0B9692B581EF7A1F61D683E63ACAD2B473C4076AA923CE44E863DAC57C9AA89E63", new byte[] { 144, 31, 196, 219, 153, 232, 189, 177, 33, 143, 244, 162, 79, 71, 129, 17, 219, 132, 71, 64, 189, 41, 216, 247, 217, 255, 199, 80, 219, 49, 194, 235, 95, 4, 140, 178, 84, 3, 11, 107, 211, 143, 6, 70, 131, 165, 93, 201, 191, 49, 253, 100, 229, 27, 10, 230, 159, 156, 108, 105, 156, 46, 149, 23 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 2, 20, 15, 25, 45, 272, DateTimeKind.Local).AddTicks(7893), "BBC09AA7C466013AFD04A7C06296DAB7E78FDB5118EAB4559FF1862BF03BBC7589CEBEC1F371FAC8E74072C6C900DD9B9B5033D33EB65562D9B5E0CC9289C177", new byte[] { 98, 198, 36, 157, 106, 237, 155, 171, 50, 7, 87, 167, 208, 5, 254, 64, 249, 66, 231, 211, 149, 28, 226, 243, 229, 232, 133, 91, 101, 163, 213, 39, 159, 0, 97, 197, 156, 110, 43, 152, 180, 112, 25, 7, 11, 129, 87, 237, 195, 179, 63, 162, 39, 215, 50, 172, 98, 205, 40, 136, 54, 248, 39, 222 } });
        }
    }
}
