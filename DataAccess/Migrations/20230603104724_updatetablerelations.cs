using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatetablerelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "AddVehicleId",
                table: "VehicleImages",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 3, 10, 47, 24, 308, DateTimeKind.Utc).AddTicks(4683));

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImages_AddVehicleId",
                table: "VehicleImages",
                column: "AddVehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImages_AddVehicle_AddVehicleId",
                table: "VehicleImages",
                column: "AddVehicleId",
                principalTable: "AddVehicle",
                principalColumn: "AvId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleImages_AddVehicle_AddVehicleId",
                table: "VehicleImages");

            migrationBuilder.DropIndex(
                name: "IX_VehicleImages_AddVehicleId",
                table: "VehicleImages");

            migrationBuilder.AlterColumn<string>(
                name: "AddVehicleId",
                table: "VehicleImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 53, 38, 509, DateTimeKind.Utc).AddTicks(9318));
        }
    }
}
