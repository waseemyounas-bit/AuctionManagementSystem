using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DEVELOPMENTPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 17, 42, 6, 90, DateTimeKind.Utc).AddTicks(6280));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 7, 10, 21, 1, 142, DateTimeKind.Utc).AddTicks(517));
        }
    }
}
