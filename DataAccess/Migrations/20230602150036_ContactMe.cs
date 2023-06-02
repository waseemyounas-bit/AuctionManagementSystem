﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ContactMe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddVehicle",
                columns: table => new
                {
                    AvId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CORType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OORMilegeRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehiclePurchaseMoth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehiclePurchaseYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vmiles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mileageDistanceUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleOwnerShipHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VownershipRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vaccident = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    btnVehicleAccident = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VaccidentRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDamage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDamageRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VSeller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DealerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vtitled = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VtitledRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleLocated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reserve = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReserveRemaks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdInfoRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddVehicle", x => x.AvId);
                });

            migrationBuilder.CreateTable(
                name: "ContactMe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaceBid",
                columns: table => new
                {
                    BidId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Userid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BidAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BidTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceBid", x => x.BidId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddVehicleId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleImages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FullName", "IsApproved", "Password", "RoleId" },
                values: new object[] { new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"), new DateTime(2023, 6, 2, 15, 0, 36, 343, DateTimeKind.Utc).AddTicks(1140), "admin@auctionsystem.com", "SuperAdmin", 1, "12345678", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddVehicle");

            migrationBuilder.DropTable(
                name: "ContactMe");

            migrationBuilder.DropTable(
                name: "PlaceBid");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VehicleImages");
        }
    }
}
