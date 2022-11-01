using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopGiaySolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "1e54700a-73ef-496b-8eff-a350d2ce2b03");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "140dbce0-cb6f-4c87-a61c-48b6facf0898", "AQAAAAEAACcQAAAAEF6TXQ1omWLPnrQuMB9roPm5EniDYek82jOfcJTT+qPdGGMRwV5df5t9HlY25FbYaQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 9, 21, 19, 23, 1, 729, DateTimeKind.Local).AddTicks(6915));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "2275e3b2-b5b6-4a24-aca1-e657e36be17b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3248cf62-28aa-4901-b73d-a125b9f138fe", "AQAAAAEAACcQAAAAELKJSWlbC/fNE1tFbHIl3nblKuUzdzIeEUwhQJHlbYQVhyw6Co/Wpay/jnz6HxgDCw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 9, 21, 17, 58, 46, 942, DateTimeKind.Local).AddTicks(5932));
        }
    }
}
