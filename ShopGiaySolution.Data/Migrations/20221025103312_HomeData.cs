using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopGiaySolution.Data.Migrations
{
    public partial class HomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6b6146c3-7e58-4164-983c-2dbaab2f8015");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15607966-3ac9-4391-b4f1-1a4352debf39", "AQAAAAEAACcQAAAAEGpWZIoPxKkV9NJN4GneFq488XHKmC7dut73+MxA5mHkG1dreYmsg7piU3uq4imK/A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 25, 17, 33, 11, 800, DateTimeKind.Local).AddTicks(4705));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Products");

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
    }
}
