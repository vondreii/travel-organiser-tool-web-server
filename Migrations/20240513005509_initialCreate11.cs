using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageFilename",
                value: "beijing.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageFilename",
                value: "shanghai.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageFilename",
                value: "mumbai.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageFilename",
                value: "kolkata.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageFilename",
                value: "hyderabad.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageFilename",
                value: "osaka.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageFilename",
                value: "hiroshima.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageFilename",
                value: "kuala-lumpur.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageFilename",
                value: "manila.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageFilename",
                value: "singapore.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageFilename",
                value: "bangkok.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageFilename",
                value: "phuket.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageFilename",
                value: "ho-chi-minh-city.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageFilename",
                value: "hanoi.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageFilename",
                value: "brussels.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageFilename",
                value: "bruges.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageFilename",
                value: "copenhagen.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageFilename",
                value: "helsinki.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageFilename",
                value: "paris.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageFilename",
                value: "berlin.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageFilename",
                value: "dublin.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageFilename",
                value: "galway.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageFilename",
                value: "rome.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageFilename",
                value: "venice.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageFilename",
                value: "florence.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 62,
                column: "ImageFilename",
                value: "mcmurdo-station.jpg");

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageFilename",
                value: "tokyo.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 62,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
