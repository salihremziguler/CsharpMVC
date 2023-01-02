using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HayvanBarinagiCalisma.Migrations
{
    public partial class mg42621 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7e832ee8-555b-4458-b378-fa54c48b4529");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4e021095-2d8d-428e-89c7-e313e1b5b672");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "1314540c-56ef-4075-8984-801bf8d49bc1", "b201210055@sakarya.edu.tr", "B201210055@SAKARYA.EDU.TR", "B201210055@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAEFIIgUoOBxsOIo6dEhrhDWHrGWcxoBVzG6Uf/SJL0VoqDLNQNqx+g/16tJKgsZ11uw==", "b201210055@sakarya.edu.tr" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8aa6ed4b-f435-4539-96a7-808170c51f41", "AQAAAAEAACcQAAAAEMhhsT+sIMDgG4jO5LX9BbODntd0P+pb2aKo34PGjq8Uiv3SFw89ztU6N1J0AI4iww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cef554d6-cd53-47b1-9737-a0ddd77e085f", "AQAAAAEAACcQAAAAEJa/n+wVKhw5DGnNCB60UO5iY+zhhaMKIiHRYp3FtVoi7yH91qMOr7mvM1du/wEdXw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "305ff164-9729-4266-b85f-28f8d4a53f0a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c921c493-d010-4eef-a3b0-ca2c677df143");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "9964897b-0875-4c69-9b2b-cf1bfe0a940f", "b191210049@sakarya.edu.tr", "B191210049@SAKARYA.EDU.TR", "B191210049@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAEPJHZm8j0qhf+eyg+p2176iPJkJReu9qHAZ7OHBx/k2ZgVJWhJJDGU7RmsewW3S3nQ==", "b191210049@sakarya.edu.tr" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "47c72294-7f4c-4206-9274-150863d9ca19", "AQAAAAEAACcQAAAAEKKSveLnaX0RZunZdDSMF2pA+/Gj+xa/zLhx4lnC+AAppT9e0xoMM108OcVDGVPu4w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e04a676a-56f3-4a6e-84e4-c664046a0e20", "AQAAAAEAACcQAAAAEO0QYg9NTp1A5aHe0wuA1WpcL+LGilWPvS+nvGf+VTJ2jXtORQa13O5+HeZ4S3nTWg==" });
        }
    }
}
