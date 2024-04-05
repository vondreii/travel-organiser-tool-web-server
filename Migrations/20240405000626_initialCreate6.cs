using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
