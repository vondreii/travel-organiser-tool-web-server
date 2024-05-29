using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "ClimateTypeID", "CountryID", "ImageFilename", "Name", "PopulationTypeID", "TerrainTypeID" },
                values: new object[,]
                {
                    { 63001, 1, 63, "no-image.jpg", "London", 1, 1 },
                    { 63002, 1, 63, "no-image.jpg", "Bristol", 1, 1 },
                    { 63003, 1, 63, "no-image.jpg", "Birmingham", 1, 1 },
                    { 63004, 1, 63, "no-image.jpg", "Tower Bridge", 1, 1 },
                    { 63005, 1, 63, "no-image.jpg", "Buckingham Palace", 1, 1 },
                    { 63006, 1, 63, "no-image.jpg", "Seven Sisters", 1, 1 },
                    { 64001, 1, 64, "no-image.jpg", "Edinburgh", 1, 1 },
                    { 64002, 1, 64, "no-image.jpg", "Glasgow", 1, 1 },
                    { 64003, 1, 64, "no-image.jpg", "Aberdeen", 1, 1 },
                    { 64004, 1, 64, "no-image.jpg", "Edinburgh Castle", 1, 1 },
                    { 64005, 1, 64, "no-image.jpg", "Balmoral Castle", 1, 1 },
                    { 65001, 1, 65, "no-image.jpg", "Cardiff", 1, 1 },
                    { 65002, 1, 65, "no-image.jpg", "Newport", 1, 1 },
                    { 65003, 1, 65, "no-image.jpg", "St Davids", 1, 1 },
                    { 65004, 1, 65, "no-image.jpg", "Conwy Castle", 1, 1 },
                    { 65005, 1, 65, "no-image.jpg", "Pembroke Castle", 1, 1 },
                    { 66001, 1, 66, "no-image.jpg", "Belfast", 1, 1 },
                    { 66002, 1, 66, "no-image.jpg", "Tully Castle", 1, 1 },
                    { 66003, 1, 66, "no-image.jpg", "Titanic Belfast", 1, 1 },
                    { 66004, 1, 66, "no-image.jpg", "Ballydugan Medieval Settlement", 1, 1 },
                    { 66005, 1, 66, "no-image.jpg", "Giant's Causeway", 1, 1 },
                    { 67001, 1, 67, "no-image.jpg", "Dublin", 1, 1 },
                    { 67002, 1, 67, "no-image.jpg", "Galway", 1, 1 },
                    { 67003, 1, 67, "no-image.jpg", "Blarney Castle", 1, 1 },
                    { 67004, 1, 67, "no-image.jpg", "Kilkenny Castle", 1, 1 },
                    { 67005, 1, 67, "no-image.jpg", "Dunluce Castle", 1, 1 },
                    { 68001, 1, 68, "no-image.jpg", "Vienna", 1, 1 },
                    { 68002, 1, 68, "no-image.jpg", "Graz", 1, 1 },
                    { 68003, 1, 68, "no-image.jpg", "Schonbrunn Palace", 1, 1 },
                    { 68004, 1, 68, "no-image.jpg", "The Alps", 1, 1 },
                    { 69001, 1, 69, "no-image.jpg", "Sofia", 1, 1 },
                    { 69002, 1, 69, "no-image.jpg", "Rila Monastery", 1, 1 },
                    { 69003, 1, 69, "no-image.jpg", "Rila National Park", 1, 1 },
                    { 69004, 1, 69, "no-image.jpg", "Seven Rila Lakes", 1, 1 },
                    { 69005, 1, 69, "no-image.jpg", "Vitosha", 1, 1 },
                    { 70001, 1, 70, "no-image.jpg", "Brussels", 1, 1 },
                    { 70002, 1, 70, "no-image.jpg", "Bruges", 1, 1 },
                    { 71001, 1, 71, "no-image.jpg", "Prague", 1, 1 },
                    { 71002, 1, 71, "no-image.jpg", "Karlovy Vary", 1, 1 },
                    { 71003, 1, 71, "no-image.jpg", "Bohemian Switzerland National Park", 1, 1 },
                    { 72001, 1, 72, "no-image.jpg", "Paris", 1, 1 },
                    { 72002, 1, 72, "no-image.jpg", "Marseille", 1, 1 },
                    { 72003, 1, 72, "no-image.jpg", "Eiffel Tower", 1, 1 },
                    { 72004, 1, 72, "no-image.jpg", "Arc de Triomphe", 1, 1 },
                    { 72005, 1, 72, "no-image.jpg", "Nice", 1, 1 },
                    { 73001, 1, 73, "no-image.jpg", "Berlin", 1, 1 },
                    { 73002, 1, 73, "no-image.jpg", "Hamburg", 1, 1 },
                    { 73003, 1, 73, "no-image.jpg", "Munich", 1, 1 },
                    { 73004, 1, 73, "no-image.jpg", "Cologne Cathedral", 1, 1 },
                    { 73005, 1, 73, "no-image.jpg", "Brandenburg Gate", 1, 1 },
                    { 73006, 1, 73, "no-image.jpg", "Neuschwanstein Castle", 1, 1 },
                    { 74001, 1, 74, "no-image.jpg", "Budapest", 1, 1 },
                    { 74002, 1, 74, "no-image.jpg", "Debrecen", 1, 1 },
                    { 74003, 1, 74, "no-image.jpg", "Buda Castle", 1, 1 },
                    { 75001, 1, 75, "no-image.jpg", "Vaduz", 1, 1 },
                    { 75002, 1, 75, "no-image.jpg", "Balzers", 1, 1 },
                    { 77001, 1, 77, "no-image.jpg", "Luxembourg", 1, 1 },
                    { 77002, 1, 77, "no-image.jpg", "Vianden", 1, 1 },
                    { 77003, 1, 77, "no-image.jpg", "Vianden Castle", 1, 1 },
                    { 78001, 1, 78, "no-image.jpg", "Amsterdam", 1, 1 },
                    { 78002, 1, 78, "no-image.jpg", "Rotterdam", 1, 1 },
                    { 78003, 1, 78, "no-image.jpg", "The Hague", 1, 1 },
                    { 78004, 1, 78, "no-image.jpg", "Keukenhof", 1, 1 },
                    { 78005, 1, 78, "no-image.jpg", "Arboretum Trompenburg", 1, 1 },
                    { 79001, 1, 79, "no-image.jpg", "Warsaw", 1, 1 },
                    { 79002, 1, 79, "no-image.jpg", "Krakow", 1, 1 },
                    { 79003, 1, 79, "no-image.jpg", "St Mary's Basilica", 1, 1 },
                    { 79004, 1, 79, "no-image.jpg", "Malbork Castle", 1, 1 },
                    { 80001, 1, 80, "no-image.jpg", "Bucharest", 1, 1 },
                    { 80002, 1, 80, "no-image.jpg", "Brasov", 1, 1 },
                    { 80003, 1, 80, "no-image.jpg", "Danube Delta", 1, 1 },
                    { 80004, 1, 80, "no-image.jpg", "Piatra Craiului Mountains", 1, 1 },
                    { 80005, 1, 80, "no-image.jpg", "Bigar Cascade Falls", 1, 1 },
                    { 81001, 1, 81, "no-image.jpg", "Belgrade", 1, 1 },
                    { 81002, 1, 81, "no-image.jpg", "Sjenica", 1, 1 },
                    { 81003, 1, 81, "no-image.jpg", "Belgrade Fortress", 1, 1 },
                    { 81004, 1, 81, "no-image.jpg", "The Temple of Saint Sava", 1, 1 },
                    { 81005, 1, 81, "no-image.jpg", "Tara", 1, 1 },
                    { 81006, 1, 81, "no-image.jpg", "Kopaonik", 1, 1 },
                    { 82001, 1, 82, "no-image.jpg", "Bratislava", 1, 1 },
                    { 82002, 1, 82, "no-image.jpg", "Bardejov", 1, 1 },
                    { 82003, 1, 82, "no-image.jpg", "Poprad", 1, 1 },
                    { 82004, 1, 82, "no-image.jpg", "Low Tatras National Park", 1, 1 },
                    { 82005, 1, 82, "no-image.jpg", "Tatra Mountains", 1, 1 },
                    { 83001, 1, 83, "no-image.jpg", "Bern", 1, 1 },
                    { 83002, 1, 83, "no-image.jpg", "Zurich", 1, 1 },
                    { 83003, 1, 83, "no-image.jpg", "Geneva", 1, 1 },
                    { 83004, 1, 83, "no-image.jpg", "Matterhorn", 1, 1 },
                    { 83005, 1, 83, "no-image.jpg", "Piz Bernina", 1, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 63001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 63002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 63003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 63004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 63005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 63006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 64001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 64002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 64003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 64004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 64005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 65001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 65002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 65003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 65004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 65005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 66001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 66002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 66003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 66004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 66005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 67001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 67002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 67003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 67004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 67005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 68001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 68002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 68003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 68004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 69001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 69002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 69003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 69004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 69005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 70001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 70002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 71001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 71002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 71003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 72001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 72002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 72003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 72004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 72005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 73001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 73002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 73003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 73004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 73005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 73006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 74001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 74002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 74003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 75001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 75002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 77001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 77002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 77003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 78001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 78002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 78003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 78004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 78005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 79001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 79002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 79003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 79004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 80001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 80002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 80003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 80004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 80005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 81001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 81002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 81003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 81004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 81005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 81006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 82001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 82002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 82003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 82004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 82005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 83001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 83002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 83003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 83004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 83005);

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "ImageFilename", "Name", "RegionID" },
                values: new object[] { 76, "no-image.jpg", "Lithuania", 8 });
        }
    }
}
