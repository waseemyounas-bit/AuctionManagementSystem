using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class sellerType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                value: new DateTime(2023, 6, 3, 17, 56, 49, 818, DateTimeKind.Utc).AddTicks(5064));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sellerType",
                table: "AddVehicle");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 3, 16, 51, 7, 674, DateTimeKind.Utc).AddTicks(2231));
        }
    }
}
