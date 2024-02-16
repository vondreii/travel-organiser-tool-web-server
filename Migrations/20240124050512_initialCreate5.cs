using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "City", "CountryID", "StateOrProvince" },
                values: new object[,]
                {
                    { 3, "Seoul", 3, "Gyeonggi region" },
                    { 4, "Berlin", 4, "Berlin" },
                    { 5, "Paris", 5, "Ile-de-France" },
                    { 6, "New York", 6, "New York" },
                    { 7, "Toronto", 7, "Ontario" },
                    { 8, "Rio de Janeiro", 8, "State of Rio de Janeiro" },
                    { 9, "Buenos Aires", 9, "Eastern Argentina" },
                    { 10, "Johannesburg", 10, "Gauteng province" },
                    { 11, "Nairobi", 11, "Nairobi County" }
                });

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Example Trip: Visiting Family in Sydney");

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Example Trip: Visiting Tokyo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Visiting Family in Sydney");

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Visiting Tokyo");
        }
    }
}
