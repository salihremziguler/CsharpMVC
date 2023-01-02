using Microsoft.EntityFrameworkCore.Migrations;

namespace HayvanBarinagiCalisma.Migrations
{
    public partial class mg47 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "e7f27f1f-7d97-4c98-ae7c-c05f9c06db87");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c3cfc2e2-4b77-424c-a372-e75ec6aa91a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79b0d806-b3e6-4ca1-befd-a798abab42bc", "AQAAAAEAACcQAAAAEIqZwGz26Tw76TxCe5QVI8PHYyqr4eB4nImfUiKObRqdUej5Lgj8zTHSctYObKKHzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b7a81036-70da-46df-8a64-53e9b8bdcd97", "AQAAAAEAACcQAAAAELiCcnsKsp8yu2R8t/uyyVKPXxxKZqun1/3O7Za3CAPWwDv51IBnLt8OGwpIOl+kjg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1a45e90-c539-4eb2-8db4-3921dea0b3cb", "AQAAAAEAACcQAAAAEESagyQsUhRAYLZ2aCCLbvdl7FFzcGu5WqmUHnl4+yvjCL8KBnRnfECQLL4MgZpvYQ==" });
        }
    }
}
