using Microsoft.EntityFrameworkCore.Migrations;

namespace HayvanBarinagiCalisma.Migrations
{
    public partial class mg82 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "75976d98-01fd-49e6-98f0-8c30191c8a7c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b7492ee3-fc0c-465f-a43c-44cf24744483");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "UserName" },
                values: new object[] { "81b759cb-3e97-465d-92f2-a319288f7561", "b201210019@sakarya.edu.tr", "B201210019@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAEOPUI0q8fGFI7HKHdp98BcgNQP56XD8/tHu3H8CKRVHucFQ4tkv7gxzJpfjWcu44vQ==", "b201210019@sakarya.edu.tr" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "UserName" },
                values: new object[] { "d6483fa7-7617-4bcd-8b18-702300b99423", "b20121020@sakarya.edu.tr", "B20121020@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAED2wS6kmkBvtZlGnVVaArNH4ujjXygmb3yVKL/dcT3v+ZEW9l7bDEusN9QvRH1npFw==", "b20121020sakarya.edu.tr" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "d14c6aec-7264-47b2-a02a-b1fee4c8239f", "g201210019@sakarya.edu.tr", "G201210019@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAEIbTEkIDbwPBvMygH+nuuLvh620sWqd0DQAJ/UXPRBo0GZ71WDkJc8rDex5T9h2rxQ==", "g201210019@sakarya.edu.tr" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "UserName" },
                values: new object[] { "cde3d09f-f760-47bb-8af5-0be79186e08e", "b191210049@sakarya.edu.tr", "B191210049@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAEMnWUEo8NxVbGBA6sDhMEELc9F9kSAFyTBeQ1Bj/nN/5ZshVggm4ymK5Kk8P1JRYhA==", "b191210049@sakarya.edu.tr" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "UserName" },
                values: new object[] { "3538f04a-dc5c-45c8-b8ef-2cbb5c1767db", "b181200378@sakarya.edu.tr", "B181200378@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAEO48v6fSMruOegm9IDCMKcUMT5AnRYFNqFjMmlTa58zBtUY37EmF+zlkRwA22k6/3g==", "b181200378@sakarya.edu.tr" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "aae7b5cf-7c29-454b-aa44-a71613912d12", "g171210105@sakarya.edu.tr", "G171210105@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAECw5jeL5Zrp2DtNN5rKLhxI781eF4tCE2dQsv6cyKKQ3CuDtmyVNtQ4/D0WGB2t1UA==", "g171210105@sakarya.edu.tr" });
        }
    }
}
