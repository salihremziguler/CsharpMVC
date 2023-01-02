using Microsoft.EntityFrameworkCore.Migrations;

namespace HayvanBarinagiCalisma.Migrations
{
    public partial class mg79 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Adi",
                table: "Araba",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ed11ee2b-2182-4a6f-93d6-aae14dccd332");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f4d81536-3c2f-4fdc-9c0b-f47fd554afb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cde3d09f-f760-47bb-8af5-0be79186e08e", "AQAAAAEAACcQAAAAEMnWUEo8NxVbGBA6sDhMEELc9F9kSAFyTBeQ1Bj/nN/5ZshVggm4ymK5Kk8P1JRYhA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3538f04a-dc5c-45c8-b8ef-2cbb5c1767db", "AQAAAAEAACcQAAAAEO48v6fSMruOegm9IDCMKcUMT5AnRYFNqFjMmlTa58zBtUY37EmF+zlkRwA22k6/3g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aae7b5cf-7c29-454b-aa44-a71613912d12", "AQAAAAEAACcQAAAAECw5jeL5Zrp2DtNN5rKLhxI781eF4tCE2dQsv6cyKKQ3CuDtmyVNtQ4/D0WGB2t1UA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Adi",
                table: "Araba",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "db5f6043-44d4-4b67-a211-12825fbc432a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "bdf6a1e3-ca46-4449-9e93-518a98cb0660");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b7aeff4-15a3-4b9b-87be-f1568ab13d90", "AQAAAAEAACcQAAAAEMrXAAXl62nUJIr2NOq6hZZLsoBXnzjlUT7/LAmvfzb1/p23S2VUWyuKOU7aJP1RzQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c088369-187c-4a3d-99dd-5e501096992e", "AQAAAAEAACcQAAAAEFm7QZsWokQ2LUl9K3A2xMRsX9l5cfjUEB5Gb4+FRuOeGKMzNnlygYejUpXoGtWVPQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d470026-39da-4d8e-8f9f-afabc708486c", "AQAAAAEAACcQAAAAEDpL9wLq2LxsexIjw/MwRqM4q++ibzTCAJZPXRSC775lccJlupKiajRjlj5qGMBvjw==" });
        }
    }
}
