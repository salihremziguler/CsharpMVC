using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HayvanBarinagiCalisma.Migrations
{
    public partial class mg4262 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9964897b-0875-4c69-9b2b-cf1bfe0a940f", "AQAAAAEAACcQAAAAEPJHZm8j0qhf+eyg+p2176iPJkJReu9qHAZ7OHBx/k2ZgVJWhJJDGU7RmsewW3S3nQ==" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
