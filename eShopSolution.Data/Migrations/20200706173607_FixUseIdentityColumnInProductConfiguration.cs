using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class FixUseIdentityColumnInProductConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("40fa8cd9-8fca-46c1-9859-1b11c2e92adb"),
                column: "ConcurrencyStamp",
                value: "c90bdd1c-0b2a-4e08-8a9e-a8129c1203e1");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("408b4b21-707a-40b6-abe6-db868e7adbd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ac476d8-ed03-40c6-a879-1871c28ee5d4", "AQAAAAEAACcQAAAAEE4SZNiRAk61f2hLGjWZCKUxcuQR6+MJAeqt/nSn/4XSgJM3CjDSKv+qVf2ahnlGyA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 7, 7, 0, 36, 6, 398, DateTimeKind.Local).AddTicks(4309));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("40fa8cd9-8fca-46c1-9859-1b11c2e92adb"),
                column: "ConcurrencyStamp",
                value: "78bc9fe9-fcf0-4de8-af04-ac9538f26dad");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("408b4b21-707a-40b6-abe6-db868e7adbd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "00d19893-34b9-4bdd-a946-c3a033c57cbe", "AQAAAAEAACcQAAAAEJ6mv8E8gWw9T7qbd9LF17ClWBKWnzTVu4A4PCsK/k3x1/ydo96DgP8SBFAzwob2MQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 7, 3, 17, 45, 18, 290, DateTimeKind.Local).AddTicks(6546));
        }
    }
}
