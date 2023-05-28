using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddvehicleImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddVehicle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VIN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    COR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CORType = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    odometerreadingreflect = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    OORMilegeRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehiclePurchaseMoth = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    VehiclePurchaseYear = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Vmiles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mileageDistanceUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleOwnerShipHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VownershipRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vaccident = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    btnVehicleAccident = table.Column<int>(type: "int", nullable: true),
                    VaccidentRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDamage = table.Column<int>(type: "int", nullable: true),
                    VDamageRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VSeller = table.Column<int>(type: "int", nullable: true),
                    DealerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vtitled = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VtitledRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleStatus = table.Column<int>(type: "int", nullable: true),
                    TitleState = table.Column<int>(type: "int", nullable: true),
                    VehicleLocated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reserve = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReserveRemaks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdInfoRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddVehicle", x => x.Id);
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
                values: new object[] { new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"), new DateTime(2023, 5, 28, 19, 56, 12, 189, DateTimeKind.Utc).AddTicks(38), "admin@auctionsystem.com", "SuperAdmin", 1, "12345678", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddVehicle");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VehicleImages");
        }
    }
}
