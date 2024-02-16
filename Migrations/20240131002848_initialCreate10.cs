using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CountryID", "Name" },
                values: new object[] { 20, "Nassau" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 41,
                column: "CountryID",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CountryID", "Name" },
                values: new object[] { 21, "Vancouver" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CountryID", "Name" },
                values: new object[] { 22, "Montego Bay" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CountryID", "Name" },
                values: new object[] { 23, "Mexico City" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CountryID", "Name" },
                values: new object[] { 24, "Boston" });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "CountryID", "Name" },
                values: new object[,]
                {
                    { 46, 24, "Chicago" },
                    { 47, 24, "Los Angeles" },
                    { 48, 24, "New York" },
                    { 49, 25, "Buenos Aires" },
                    { 50, 26, "Rio de Janeiro" },
                    { 51, 26, "Salvador" },
                    { 52, 26, "Sao Paulo" },
                    { 53, 27, "Santiago" },
                    { 54, 28, "Quito" },
                    { 55, 29, "Arequipa" },
                    { 56, 30, "Addis Ababa" },
                    { 57, 31, "Nairobi" },
                    { 58, 32, "Lagos" },
                    { 59, 33, "Kigali" },
                    { 60, 34, "Johannesburg" },
                    { 61, 35, "Harare" },
                    { 62, 36, "McMurdo Station" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CountryID", "Name" },
                values: new object[] { 6, "New York" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 41,
                column: "CountryID",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CountryID", "Name" },
                values: new object[] { 8, "Rio de Janeiro" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CountryID", "Name" },
                values: new object[] { 9, "Buenos Aires" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CountryID", "Name" },
                values: new object[] { 10, "Johannesburg" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CountryID", "Name" },
                values: new object[] { 11, "Nairobi" });
        }
    }
}
