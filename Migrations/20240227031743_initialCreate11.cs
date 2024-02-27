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
            migrationBuilder.AddColumn<string>(
                name: "ImageFilename",
                table: "Country",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageFilename",
                value: "australia.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageFilename",
                value: "china.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageFilename",
                value: "india.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageFilename",
                value: "japan.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageFilename",
                value: "malaysia.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageFilename",
                value: "philippines.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageFilename",
                value: "singapore.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageFilename",
                value: "south-korea.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageFilename",
                value: "thailand.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageFilename",
                value: "vietnam.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageFilename",
                value: "no-image.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFilename",
                table: "Country");
        }
    }
}
