using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class RentedBooksMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RentedBooks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentedBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentedBooks_Books_UserId",
                        column: x => x.UserId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentedBooks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(6172), new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(6179), new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(6184), new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(5963), new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(6035), new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(6042), new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(6047), new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 24, 17, 27, 5, 23, DateTimeKind.Local).AddTicks(4709), new DateTime(2023, 2, 24, 17, 27, 5, 23, DateTimeKind.Local).AddTicks(4745), "5BF1BEFF18A7B62FE96FB7AD4F8179BFF6F6DC00DB25F1ADD50DB1CD742AD03815A6347D917AC9B4BD151E946639931843730BC8274649CCDE69B6A16A96ED59", new byte[] { 105, 75, 64, 2, 44, 137, 197, 45, 8, 219, 65, 122, 76, 219, 73, 94, 196, 59, 219, 237, 179, 253, 7, 27, 87, 125, 144, 186, 253, 89, 100, 64, 160, 134, 204, 14, 223, 68, 255, 15, 19, 104, 63, 28, 29, 248, 214, 86, 235, 236, 126, 178, 207, 167, 253, 164, 240, 209, 52, 37, 16, 118, 165, 45 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 24, 17, 27, 5, 249, DateTimeKind.Local).AddTicks(7395), new DateTime(2023, 2, 24, 17, 27, 5, 249, DateTimeKind.Local).AddTicks(7446), "DBA8417873556C394704C9B0103D8106C27B134BA2B6A6A9A0E3728231D747D479330C677827360E2EF81BAF93AE0F40B48E2E7414051FC4F4D0B5318196B741", new byte[] { 54, 187, 201, 53, 44, 137, 247, 53, 188, 44, 224, 155, 204, 177, 133, 99, 100, 243, 4, 107, 95, 110, 127, 84, 182, 5, 83, 6, 20, 252, 215, 126, 116, 193, 47, 211, 87, 4, 131, 171, 106, 100, 132, 60, 161, 214, 112, 10, 252, 10, 18, 212, 87, 72, 233, 131, 134, 195, 180, 131, 151, 36, 171, 241 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 24, 17, 27, 5, 477, DateTimeKind.Local).AddTicks(2446), new DateTime(2023, 2, 24, 17, 27, 5, 477, DateTimeKind.Local).AddTicks(2492), "80BCAB67B45F5CD00A54DA1F623C79E7CA69B2D72474C5982CF93CD325050F4F9427B88EB3E5F4EEBE77A34B4A01CB5C80F32EF4AFCAC350E2301FE2ADD49B6E", new byte[] { 15, 201, 109, 152, 177, 176, 238, 94, 172, 238, 18, 53, 26, 192, 19, 141, 69, 254, 241, 44, 128, 63, 172, 133, 117, 248, 137, 179, 181, 111, 151, 3, 82, 92, 247, 209, 249, 128, 106, 106, 139, 145, 137, 163, 216, 28, 219, 159, 71, 170, 139, 157, 131, 58, 64, 148, 45, 247, 152, 203, 182, 199, 19, 22 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(4765), new DateTime(2023, 2, 24, 17, 27, 5, 704, DateTimeKind.Local).AddTicks(4802), "4BC1EC882F19CEE5CDC20E7DF939BC2294A33097782C7AC57BDABDF1EB4E332CCEA3282C124B47A3E4D27F94288455BBD832A2D4FAA5136CFF1E307146D6C05E", new byte[] { 2, 186, 15, 253, 238, 47, 127, 57, 217, 2, 80, 13, 197, 119, 76, 47, 255, 225, 245, 89, 255, 122, 111, 179, 246, 92, 192, 220, 207, 158, 141, 72, 215, 161, 111, 31, 224, 37, 244, 206, 3, 88, 112, 48, 251, 84, 75, 74, 70, 98, 36, 130, 12, 168, 207, 178, 223, 211, 221, 69, 233, 23, 121, 54 } });

            migrationBuilder.CreateIndex(
                name: "IX_RentedBooks_UserId",
                table: "RentedBooks",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentedBooks");

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6524), new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6640), new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6647), new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6652), new DateTime(2023, 2, 24, 13, 35, 25, 199, DateTimeKind.Local).AddTicks(6654) });

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
    }
}
