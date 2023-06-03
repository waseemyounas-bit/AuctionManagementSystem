using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class bidp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "AddVehicle",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 3, 16, 18, 20, 259, DateTimeKind.Utc).AddTicks(397));

            migrationBuilder.CreateIndex(
                name: "IX_AddVehicle_UserId",
                table: "AddVehicle",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddVehicle_Users_UserId",
                table: "AddVehicle",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddVehicle_Users_UserId",
                table: "AddVehicle");

            migrationBuilder.DropIndex(
                name: "IX_AddVehicle_UserId",
                table: "AddVehicle");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AddVehicle");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 3, 16, 9, 16, 525, DateTimeKind.Utc).AddTicks(4100));
        }
    }
}
