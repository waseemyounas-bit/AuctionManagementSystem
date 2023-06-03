using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class biddingupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PlaceBid",
                table: "PlaceBid");

            migrationBuilder.DropColumn(
                name: "BidId",
                table: "PlaceBid");

            migrationBuilder.AlterColumn<Guid>(
                name: "Userid",
                table: "PlaceBid",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AddVehicleAvId",
                table: "PlaceBid",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "VehicleId",
                table: "PlaceBid",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlaceBid",
                table: "PlaceBid",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 3, 15, 43, 19, 144, DateTimeKind.Utc).AddTicks(1631));

            migrationBuilder.CreateIndex(
                name: "IX_PlaceBid_AddVehicleAvId",
                table: "PlaceBid",
                column: "AddVehicleAvId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceBid_Userid",
                table: "PlaceBid",
                column: "Userid");

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceBid_AddVehicle_AddVehicleAvId",
                table: "PlaceBid",
                column: "AddVehicleAvId",
                principalTable: "AddVehicle",
                principalColumn: "AvId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceBid_Users_Userid",
                table: "PlaceBid",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlaceBid_AddVehicle_AddVehicleAvId",
                table: "PlaceBid");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaceBid_Users_Userid",
                table: "PlaceBid");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlaceBid",
                table: "PlaceBid");

            migrationBuilder.DropIndex(
                name: "IX_PlaceBid_AddVehicleAvId",
                table: "PlaceBid");

            migrationBuilder.DropIndex(
                name: "IX_PlaceBid_Userid",
                table: "PlaceBid");

            migrationBuilder.DropColumn(
                name: "AddVehicleAvId",
                table: "PlaceBid");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "PlaceBid");

            migrationBuilder.AlterColumn<string>(
                name: "Userid",
                table: "PlaceBid",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BidId",
                table: "PlaceBid",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlaceBid",
                table: "PlaceBid",
                column: "BidId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 3, 10, 47, 24, 308, DateTimeKind.Utc).AddTicks(4683));
        }
    }
}
