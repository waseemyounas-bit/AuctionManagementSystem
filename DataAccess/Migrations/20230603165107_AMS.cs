using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AMS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 3, 16, 51, 7, 674, DateTimeKind.Utc).AddTicks(2231));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 3, 16, 18, 20, 259, DateTimeKind.Utc).AddTicks(397));
        }
    }
}
