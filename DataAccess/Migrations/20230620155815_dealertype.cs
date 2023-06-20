using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dealertype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DealerName",
                table: "AddVehicle");

            migrationBuilder.DropColumn(
                name: "sellerType",
                table: "AddVehicle");

            migrationBuilder.AddColumn<bool>(
                name: "SellerType",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                columns: new[] { "CreatedAt", "SellerType" },
                values: new object[] { new DateTime(2023, 6, 20, 15, 58, 15, 571, DateTimeKind.Utc).AddTicks(9449), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SellerType",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "DealerName",
                table: "AddVehicle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sellerType",
                table: "AddVehicle",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 10, 21, 1, 142, DateTimeKind.Utc).AddTicks(517));
        }
    }
}
