using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datetime",
                value: new DateTime(2024, 3, 19, 17, 22, 47, 66, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 2,
                column: "Datetime",
                value: new DateTime(2024, 3, 19, 17, 22, 47, 66, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 3,
                column: "Datetime",
                value: new DateTime(2024, 3, 19, 17, 22, 47, 66, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 4,
                column: "Datetime",
                value: new DateTime(2024, 3, 19, 17, 22, 47, 66, DateTimeKind.Local).AddTicks(7461));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datetime",
                value: new DateTime(2024, 3, 19, 16, 40, 45, 216, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 2,
                column: "Datetime",
                value: new DateTime(2024, 3, 19, 16, 40, 45, 216, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 3,
                column: "Datetime",
                value: new DateTime(2024, 3, 19, 16, 40, 45, 216, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 4,
                column: "Datetime",
                value: new DateTime(2024, 3, 19, 16, 40, 45, 216, DateTimeKind.Local).AddTicks(2970));
        }
    }
}
