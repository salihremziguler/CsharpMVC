using Microsoft.EntityFrameworkCore.Migrations;

namespace HayvanBarinagiCalisma.Migrations
{
    public partial class mg422 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b3dd73c6-afa2-41ff-9b03-9f9d94c349e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8e6f3ea8-0534-4286-8475-1963b36a4b45");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c574efa-015d-4dc8-a607-5272dc4bab07", "AQAAAAEAACcQAAAAEKPRJYOxX+olC3GLCIHqG4N//V+kl0A11yV8eBISlbFXcDR3+msT/EXU65UflR2MKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d71c841-439b-46a7-834f-cca8299d4453", "AQAAAAEAACcQAAAAEA8JFHHBDXN45fYRTExYnH/iniHICFYmCam/5ZZTwNtHx4DeJl95reahSlgzcboqwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "47d5c6cd-78f6-486f-a7e7-1090fbe5869d", "AQAAAAEAACcQAAAAEHb59db7fuWZ6/KaXEETglxNgmQsolA/nFTn67QHiApbKxQrCg/PolfnHG/yQG38Xg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "e8a65e46-70e7-4190-9492-837ff72f038a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "84023995-68cb-470c-9ca8-7cb6de85ab94");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8595ea27-2889-4e9c-b2f0-691d9bd88f01", "AQAAAAEAACcQAAAAEBy8IjWdbuDkBAtAkEMPRUfBMVK/DWiHfij2dB8i2EFqzXY04Uc0k3gt2S8DQYuE6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91d267be-c4bd-491c-bee2-f0778d8195d2", "AQAAAAEAACcQAAAAEPrTD5ahLDaF6YPckDrJ1aWPb8mkghvRm8Peiv+rIHUcmXmYdrhvGruWxlvIlvBEHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "90654e5a-0a7e-4b30-b5ac-0a5a135286ff", "AQAAAAEAACcQAAAAEFkWlp2ArIyc0vVbfBj8Roh8qopoOl2arJt3zEMwmVvyXILLwTvquC5qzs9iOAQ1pg==" });
        }
    }
}
