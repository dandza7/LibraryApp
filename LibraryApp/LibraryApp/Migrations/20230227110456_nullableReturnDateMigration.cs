using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.Migrations
{
    /// <inheritdoc />
    public partial class nullableReturnDateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "RentedBooks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "RentedBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
        }
    }
}
