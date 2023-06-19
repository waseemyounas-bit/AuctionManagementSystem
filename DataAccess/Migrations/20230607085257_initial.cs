using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    sellerType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vtitled = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VtitledRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleLocated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reserve = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReserveRemaks = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdInfoRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddVehicle", x => x.AvId);
                    table.ForeignKey(
                        name: "FK_AddVehicle_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlaceBid",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Userid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BidAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BidTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddVehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceBid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceBid_AddVehicle_AddVehicleId",
                        column: x => x.AddVehicleId,
                        principalTable: "AddVehicle",
                        principalColumn: "AvId");
                    table.ForeignKey(
                        name: "FK_PlaceBid_Users_Userid",
                        column: x => x.Userid,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddVehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleImages_AddVehicle_AddVehicleId",
                        column: x => x.AddVehicleId,
                        principalTable: "AddVehicle",
                        principalColumn: "AvId");
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FullName", "IsApproved", "Password", "RoleId" },
                values: new object[] { new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"), new DateTime(2023, 6, 7, 8, 52, 57, 399, DateTimeKind.Utc).AddTicks(3122), "admin@auctionsystem.com", "SuperAdmin", 1, "12345678", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AddVehicle_UserId",
                table: "AddVehicle",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceBid_AddVehicleId",
                table: "PlaceBid",
                column: "AddVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceBid_Userid",
                table: "PlaceBid",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImages_AddVehicleId",
                table: "VehicleImages",
                column: "AddVehicleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactMe");

            migrationBuilder.DropTable(
                name: "PlaceBid");

            migrationBuilder.DropTable(
                name: "VehicleImages");

            migrationBuilder.DropTable(
                name: "AddVehicle");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
