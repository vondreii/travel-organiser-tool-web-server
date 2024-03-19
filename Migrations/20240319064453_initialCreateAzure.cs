using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreateAzure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datetime",
                value: new DateTime(2024, 3, 19, 17, 44, 53, 114, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 2,
                column: "Datetime",
                value: new DateTime(2024, 3, 19, 17, 44, 53, 114, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 3,
                column: "Datetime",
                value: new DateTime(2024, 3, 19, 17, 44, 53, 114, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 4,
                column: "Datetime",
                value: new DateTime(2024, 3, 19, 17, 44, 53, 114, DateTimeKind.Local).AddTicks(1267));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
