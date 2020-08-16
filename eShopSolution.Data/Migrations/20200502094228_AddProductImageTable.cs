using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 4, 26, 19, 59, 19, 166, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 26, 19, 59, 19, 166, DateTimeKind.Local).AddTicks(4313),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("40fa8cd9-8fca-46c1-9859-1b11c2e92adb"),
                column: "ConcurrencyStamp",
                value: "093fea3f-a630-4e9b-95dd-081d05b5cc3f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("408b4b21-707a-40b6-abe6-db868e7adbd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4dee354-d9cb-47a3-8665-d3af2d1206c4", "AQAAAAEAACcQAAAAEBHnsz1x1EoZXl0vQd6mxTh+HLbmYcERoHi5VqGzRS8dC1n1Mvujosr8XXXLLpvyrw==" });

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
    }
}
