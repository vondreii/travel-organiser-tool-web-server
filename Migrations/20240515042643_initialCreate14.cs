using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11,
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
                keyValue: 25,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageFilename",
                value: "no-image.jpg");

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "ImageFilename", "Name", "RegionID" },
                values: new object[,]
                {
                    { 37, "no-image.jpg", "Indonesia", 2 },
                    { 38, "no-image.jpg", "Greece", 3 },
                    { 39, "no-image.jpg", "Cuba", 4 },
                    { 40, "no-image.jpg", "Haiti", 4 },
                    { 41, "no-image.jpg", "Panama", 4 },
                    { 42, "no-image.jpg", "Costa Rica", 4 },
                    { 43, "no-image.jpg", "Barbados", 4 },
                    { 44, "no-image.jpg", "Colombia", 5 },
                    { 45, "no-image.jpg", "Venezuela", 5 },
                    { 46, "no-image.jpg", "Guyana", 5 },
                    { 47, "no-image.jpg", "Uruguay", 5 },
                    { 48, "no-image.jpg", "Aruba", 5 },
                    { 49, "no-image.jpg", "Madagascar", 6 },
                    { 50, "no-image.jpg", "Sudan", 6 },
                    { 51, "no-image.jpg", "South Sudan", 6 },
                    { 52, "no-image.jpg", "Sierra Leone", 6 }
                });

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "CountryID", "ImageFilename", "Name" },
                values: new object[,]
                {
                    { 95, 36, "no-image.jpg", "Antarctic peninsula" },
                    { 96, 36, "no-image.jpg", "Drake Passage" },
                    { 97, 36, "no-image.jpg", "Falkland Islands" },
                    { 98, 36, "no-image.jpg", "King George Island" },
                    { 99, 36, "no-image.jpg", "Lemaire Channel" },
                    { 100, 36, "no-image.jpg", "Port Lockroy" },
                    { 101, 36, "no-image.jpg", "Ross Sea and Ross Ice Shelf" },
                    { 102, 1, "no-image.jpg", "Newcastle" },
                    { 103, 1, "no-image.jpg", "Central Coast" },
                    { 104, 1, "no-image.jpg", "Hunter Valley" },
                    { 105, 1, "no-image.jpg", "Nelson Bay" },
                    { 106, 1, "no-image.jpg", "Port Macquarie" },
                    { 63, 37, "no-image.jpg", "Jakarta" },
                    { 64, 37, "no-image.jpg", "Bali" },
                    { 65, 38, "no-image.jpg", "Athens" },
                    { 66, 38, "no-image.jpg", "Rhodes" },
                    { 67, 39, "no-image.jpg", "Havana" },
                    { 68, 39, "no-image.jpg", "Santa Clara" },
                    { 69, 40, "no-image.jpg", "Port-au-Prince" },
                    { 70, 40, "no-image.jpg", "Petion-Ville" },
                    { 71, 41, "no-image.jpg", "Panama City" },
                    { 72, 41, "no-image.jpg", "Santiago" },
                    { 73, 42, "no-image.jpg", "San Jose" },
                    { 74, 42, "no-image.jpg", "Cartago" },
                    { 75, 43, "no-image.jpg", "Bridgetown" },
                    { 76, 43, "no-image.jpg", "Saint James" },
                    { 77, 44, "no-image.jpg", "Bogota" },
                    { 78, 44, "no-image.jpg", "Cali" },
                    { 79, 45, "no-image.jpg", "Caracas" },
                    { 80, 45, "no-image.jpg", "Maracaibo" },
                    { 81, 46, "no-image.jpg", "Georgetown" },
                    { 82, 46, "no-image.jpg", "Annandale, Pomeroon-Supenaam" },
                    { 83, 47, "no-image.jpg", "Paysandu" },
                    { 84, 47, "no-image.jpg", "Montevideo" },
                    { 85, 48, "no-image.jpg", "Oranjestad" },
                    { 86, 48, "no-image.jpg", "Noord" },
                    { 87, 49, "no-image.jpg", "Antananarivo" },
                    { 88, 49, "no-image.jpg", "Nosy Be" },
                    { 89, 50, "no-image.jpg", "Omdurman" },
                    { 90, 50, "no-image.jpg", "Khartoum" },
                    { 91, 51, "no-image.jpg", "Juba" },
                    { 92, 51, "no-image.jpg", "Malakal" },
                    { 93, 52, "no-image.jpg", "Freetown" },
                    { 94, 52, "no-image.jpg", "Bo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageFilename",
                value: "belgium.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageFilename",
                value: "bahamas.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageFilename",
                value: "argentina.jpg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageFilename",
                value: "antarctica.jpg");
        }
    }
}
