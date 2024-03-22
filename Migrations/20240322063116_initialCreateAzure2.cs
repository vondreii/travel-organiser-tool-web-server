using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreateAzure2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datetime",
                value: new DateTime(2024, 3, 22, 17, 31, 16, 71, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 2,
                column: "Datetime",
                value: new DateTime(2024, 3, 22, 17, 31, 16, 71, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 3,
                column: "Datetime",
                value: new DateTime(2024, 3, 22, 17, 31, 16, 71, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 4,
                column: "Datetime",
                value: new DateTime(2024, 3, 22, 17, 31, 16, 71, DateTimeKind.Local).AddTicks(8560));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datetime",
                value: new DateTime(2024, 3, 22, 17, 1, 43, 874, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 2,
                column: "Datetime",
                value: new DateTime(2024, 3, 22, 17, 1, 43, 874, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 3,
                column: "Datetime",
                value: new DateTime(2024, 3, 22, 17, 1, 43, 874, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 4,
                column: "Datetime",
                value: new DateTime(2024, 3, 22, 17, 1, 43, 874, DateTimeKind.Local).AddTicks(7740));
        }
    }
}
