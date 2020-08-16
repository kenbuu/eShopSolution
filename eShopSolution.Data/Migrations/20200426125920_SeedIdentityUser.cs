using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 26, 19, 59, 19, 166, DateTimeKind.Local).AddTicks(4313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 4, 26, 19, 12, 56, 571, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("40fa8cd9-8fca-46c1-9859-1b11c2e92adb"), "093fea3f-a630-4e9b-95dd-081d05b5cc3f", "Adminstrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("408b4b21-707a-40b6-abe6-db868e7adbd9"), new Guid("40fa8cd9-8fca-46c1-9859-1b11c2e92adb") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("408b4b21-707a-40b6-abe6-db868e7adbd9"), 0, "c4dee354-d9cb-47a3-8665-d3af2d1206c4", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "nongtrungbuu1903@gmail.com", true, "Buu", "Nong", false, null, "nongtrungbuu1903@gmail.com", "admin", "AQAAAAEAACcQAAAAEBHnsz1x1EoZXl0vQd6mxTh+HLbmYcERoHi5VqGzRS8dC1n1Mvujosr8XXXLLpvyrw==", null, false, "", false, "admin" });

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
                value: new DateTime(2020, 4, 26, 19, 59, 19, 190, DateTimeKind.Local).AddTicks(5467));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("40fa8cd9-8fca-46c1-9859-1b11c2e92adb"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("408b4b21-707a-40b6-abe6-db868e7adbd9"), new Guid("40fa8cd9-8fca-46c1-9859-1b11c2e92adb") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("408b4b21-707a-40b6-abe6-db868e7adbd9"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 26, 19, 12, 56, 571, DateTimeKind.Local).AddTicks(6736),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 4, 26, 19, 59, 19, 166, DateTimeKind.Local).AddTicks(4313));

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
                value: new DateTime(2020, 4, 26, 19, 12, 56, 589, DateTimeKind.Local).AddTicks(3127));
        }
    }
}
