using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HayvanBarinagiCalisma.Migrations
{
    public partial class mg426 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "28ab369a-37df-436d-8a20-ea28285cc62a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5aaa1731-af02-4339-be4b-8cb3838434a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78b89a4a-2401-43ba-af78-b878bfa397ab", "AQAAAAEAACcQAAAAEJ4FubnPEOoUlNouSyjDfMMAWN2idPQ3JJ3SIbkLWixGzGZi5znw2dKc85sJ3d5iRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b40dcef-56f4-42f9-a9f8-a919fe844581", "AQAAAAEAACcQAAAAEMlGF+N0HoDOVHKoJVl+zf+7xYodtMXoEQmRx0tx8Br3GIDFNaRLQ0cjT8Gws2g09Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88b9fc17-e34f-45d5-a4f8-f4fdd4097145", "AQAAAAEAACcQAAAAECvDJ5ZYaWo1fYDiFCNr6lD4y9NBhY3EO8BLtli9OkU0Vht2Av6ziKi0mZ5cdZgRVA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
