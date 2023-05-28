using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddVehicleView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddVehicle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CORType = table.Column<int>(type: "int", nullable: true),
                    odometerreadingreflect = table.Column<int>(type: "int", nullable: true),
                    OORMilegeRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehiclePurchaseMoth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehiclePurchaseYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vmiles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mileageDistanceUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VownershipRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vaccident = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddVehicle", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2023, 5, 28, 10, 27, 0, 834, DateTimeKind.Utc).AddTicks(9225), "admin@auctionsystem.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddVehicle");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2023, 5, 27, 11, 11, 44, 188, DateTimeKind.Utc).AddTicks(7088), "admin@hrawards.com" });
        }
    }
}
