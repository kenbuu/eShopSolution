using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChageFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("40fa8cd9-8fca-46c1-9859-1b11c2e92adb"),
                column: "ConcurrencyStamp",
                value: "9afec9e3-d709-4412-aa14-c28befa98105");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("408b4b21-707a-40b6-abe6-db868e7adbd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "db01c94b-c4c5-488e-bbc2-1490ed66b12f", "AQAAAAEAACcQAAAAEEcBNEwTJvOKP5Ik5HmlqYxQH7Vsjn8CCk0PQgQO8+tIY4IxjN5kf3c4x4gPzg8wGA==" });

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
                value: new DateTime(2020, 5, 2, 16, 42, 26, 973, DateTimeKind.Local).AddTicks(4124));
        }
    }
}
