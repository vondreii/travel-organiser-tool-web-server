using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155,
                column: "Name",
                value: "Sao Tome and Principe");

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "ClimateTypeID", "CountryID", "ImageFilename", "Name", "PopulationTypeID", "TerrainTypeID" },
                values: new object[,]
                {
                    { 114001, 1, 114, "no-image.jpg", "Algiers", 1, 1 },
                    { 114002, 1, 114, "no-image.jpg", "Oran", 1, 1 },
                    { 115001, 1, 115, "no-image.jpg", "Cairo", 1, 1 },
                    { 115002, 1, 115, "no-image.jpg", "Alexandria", 1, 1 },
                    { 115003, 1, 115, "no-image.jpg", "Giza", 1, 1 },
                    { 115004, 1, 115, "no-image.jpg", "Great Sphinx of Giza", 1, 1 },
                    { 115005, 1, 115, "no-image.jpg", "Egyptian pyramids", 1, 1 },
                    { 116001, 1, 116, "no-image.jpg", "Tripoli", 1, 1 },
                    { 116002, 1, 116, "no-image.jpg", "Arc of Marcus Aurelius", 1, 1 },
                    { 117001, 1, 117, "no-image.jpg", "Fes", 1, 1 },
                    { 117002, 1, 117, "no-image.jpg", "Marrakesh", 1, 1 },
                    { 117003, 1, 117, "no-image.jpg", "Volubilis", 1, 1 },
                    { 118001, 1, 118, "no-image.jpg", "Omdurman", 1, 1 },
                    { 118002, 1, 118, "no-image.jpg", "Kassala", 1, 1 },
                    { 118003, 1, 118, "no-image.jpg", "Al-Nilein Mosque", 1, 1 },
                    { 119001, 1, 119, "no-image.jpg", "Tunis", 1, 1 },
                    { 120001, 1, 120, "no-image.jpg", "Luanda", 1, 1 },
                    { 120002, 1, 120, "no-image.jpg", "Bufalo Partial Reserve", 1, 1 },
                    { 121001, 1, 121, "no-image.jpg", "Cotonou", 1, 1 },
                    { 121002, 1, 121, "no-image.jpg", "Grande Mosquee de Porto Novo", 1, 1 },
                    { 122001, 1, 122, "no-image.jpg", "Gaborone", 1, 1 },
                    { 122002, 1, 122, "no-image.jpg", "Serowe", 1, 1 },
                    { 122003, 1, 122, "no-image.jpg", "Kanye", 1, 1 },
                    { 123001, 1, 123, "no-image.jpg", "Banfora", 1, 1 },
                    { 123002, 1, 123, "no-image.jpg", "Ouagadougou", 1, 1 },
                    { 123003, 1, 123, "no-image.jpg", "Singou Reserve", 1, 1 },
                    { 124001, 1, 124, "no-image.jpg", "Gitega", 1, 1 },
                    { 125001, 1, 125, "no-image.jpg", "Douala", 1, 1 },
                    { 125002, 1, 125, "no-image.jpg", "Yaounde", 1, 1 },
                    { 125003, 1, 125, "no-image.jpg", "Garoua", 1, 1 },
                    { 126001, 1, 126, "no-image.jpg", "Praia", 1, 1 },
                    { 126002, 1, 126, "no-image.jpg", "The Pier of Santa Maria", 1, 1 },
                    { 127001, 1, 127, "no-image.jpg", "Bangui", 1, 1 },
                    { 127002, 1, 127, "no-image.jpg", "Chinko Nature Reserve", 1, 1 },
                    { 128001, 1, 128, "no-image.jpg", "N'Djamena", 1, 1 },
                    { 129001, 1, 129, "no-image.jpg", "Moroni", 1, 1 },
                    { 130001, 1, 130, "no-image.jpg", "Kinshasa", 1, 1 },
                    { 130002, 1, 130, "no-image.jpg", "Bukavu", 1, 1 },
                    { 130003, 1, 130, "no-image.jpg", "Lubumbashi", 1, 1 },
                    { 131001, 1, 131, "no-image.jpg", "Djibouti City", 1, 1 },
                    { 131002, 1, 131, "no-image.jpg", "Maskali Island", 1, 1 },
                    { 132001, 1, 132, "no-image.jpg", "Malabo", 1, 1 },
                    { 133001, 1, 133, "no-image.jpg", "Asmara", 1, 1 },
                    { 134001, 1, 134, "no-image.jpg", "Mbabane", 1, 1 },
                    { 135001, 1, 135, "no-image.jpg", "Addis Ababa", 1, 1 },
                    { 135002, 1, 135, "no-image.jpg", "Gondar", 1, 1 },
                    { 135003, 1, 135, "no-image.jpg", "Church of St George", 1, 1 },
                    { 136001, 1, 136, "no-image.jpg", "Libreville", 1, 1 },
                    { 137001, 1, 137, "no-image.jpg", "Serekunda", 1, 1 },
                    { 138001, 1, 138, "no-image.jpg", "Kumasi", 1, 1 },
                    { 138002, 1, 138, "no-image.jpg", "Tamale", 1, 1 },
                    { 138003, 1, 138, "no-image.jpg", "Kakum National Park", 1, 1 },
                    { 139001, 1, 139, "no-image.jpg", "Conakry", 1, 1 },
                    { 140001, 1, 140, "no-image.jpg", "Bissau", 1, 1 },
                    { 141001, 1, 141, "no-image.jpg", "Abidjan", 1, 1 },
                    { 141002, 1, 141, "no-image.jpg", "Bouake", 1, 1 },
                    { 142001, 1, 142, "no-image.jpg", "Nairobi", 1, 1 },
                    { 142002, 1, 142, "no-image.jpg", "Kakamega", 1, 1 },
                    { 142003, 1, 142, "no-image.jpg", "Nairobi National Park", 1, 1 },
                    { 142004, 1, 142, "no-image.jpg", "Amboseli National Park", 1, 1 },
                    { 142005, 1, 142, "no-image.jpg", "Tsavo East National Park", 1, 1 },
                    { 143001, 1, 143, "no-image.jpg", "Maseru", 1, 1 },
                    { 144001, 1, 144, "no-image.jpg", "Monrovia", 1, 1 },
                    { 145001, 1, 145, "no-image.jpg", "Antananarivo", 1, 1 },
                    { 145002, 1, 145, "no-image.jpg", "Isalo National Park", 1, 1 },
                    { 145003, 1, 145, "no-image.jpg", "Tsingy De Bemaraha National Park", 1, 1 },
                    { 146001, 1, 146, "no-image.jpg", "Lilongwe", 1, 1 },
                    { 146002, 1, 146, "no-image.jpg", "Mount Mulanje", 1, 1 },
                    { 146003, 1, 146, "no-image.jpg", "Lake Malawi", 1, 1 },
                    { 147001, 1, 147, "no-image.jpg", "Bamako", 1, 1 },
                    { 148001, 1, 148, "no-image.jpg", "Nouakchott", 1, 1 },
                    { 149001, 1, 149, "no-image.jpg", "Port Louis", 1, 1 },
                    { 149002, 1, 149, "no-image.jpg", "Crystal Rock", 1, 1 },
                    { 150001, 1, 150, "no-image.jpg", "Maputo", 1, 1 },
                    { 151001, 1, 151, "no-image.jpg", "Windhoek", 1, 1 },
                    { 152001, 1, 152, "no-image.jpg", "Niamey", 1, 1 },
                    { 153001, 1, 153, "no-image.jpg", "Abuja", 1, 1 },
                    { 154001, 1, 154, "no-image.jpg", "Kigali", 1, 1 },
                    { 155001, 1, 155, "no-image.jpg", "Sao Tome", 1, 1 },
                    { 156001, 1, 156, "no-image.jpg", "Dakar", 1, 1 },
                    { 157001, 1, 157, "no-image.jpg", "Victoria", 1, 1 },
                    { 158001, 1, 158, "no-image.jpg", "Freetown", 1, 1 },
                    { 158002, 1, 158, "no-image.jpg", "Mount Bintumani", 1, 1 },
                    { 159001, 1, 159, "no-image.jpg", "Mogadishu", 1, 1 },
                    { 160001, 1, 160, "no-image.jpg", "Cape Town", 1, 1 },
                    { 160002, 1, 160, "no-image.jpg", "Kruger National Park", 1, 1 },
                    { 160003, 1, 160, "no-image.jpg", "Maclear's Beacon", 1, 1 },
                    { 160004, 1, 160, "no-image.jpg", "Voortrekker Monument", 1, 1 },
                    { 160005, 1, 160, "no-image.jpg", "Cape of Good Hope", 1, 1 },
                    { 161001, 1, 161, "no-image.jpg", "Juba", 1, 1 },
                    { 161002, 1, 161, "no-image.jpg", "White Nile", 1, 1 },
                    { 162001, 1, 162, "no-image.jpg", "Khartoum", 1, 1 },
                    { 163001, 1, 163, "no-image.jpg", "Dodoma", 1, 1 },
                    { 164001, 1, 164, "no-image.jpg", "Lome", 1, 1 },
                    { 165001, 1, 165, "no-image.jpg", "Kampala", 1, 1 },
                    { 165002, 1, 165, "no-image.jpg", "Queen Elizabeth National Park", 1, 1 },
                    { 166001, 1, 166, "no-image.jpg", "Lusaka", 1, 1 },
                    { 167001, 1, 167, "no-image.jpg", "Harare", 1, 1 },
                    { 167002, 1, 167, "no-image.jpg", "Victoria Falls Bridge", 1, 1 },
                    { 167003, 1, 167, "no-image.jpg", "Worlds View", 1, 1 },
                    { 167004, 1, 167, "no-image.jpg", "Nesbitt Castle", 1, 1 },
                    { 168001, 1, 168, "no-image.jpg", "Ottawa", 1, 1 },
                    { 168002, 1, 168, "no-image.jpg", "Quebec City", 1, 1 },
                    { 168003, 1, 168, "no-image.jpg", "Vancouver", 1, 1 },
                    { 168004, 1, 168, "no-image.jpg", "Toronto", 1, 1 },
                    { 168005, 1, 168, "no-image.jpg", "Winnipeg", 1, 1 },
                    { 168006, 1, 168, "no-image.jpg", "Calgary", 1, 1 },
                    { 168007, 1, 168, "no-image.jpg", "Edmonton", 1, 1 },
                    { 168008, 1, 168, "no-image.jpg", "Niagara Falls Canada", 1, 1 },
                    { 168009, 1, 168, "no-image.jpg", "Hopewell Rocks", 1, 1 },
                    { 168010, 1, 168, "no-image.jpg", "Banff National Park", 1, 1 },
                    { 168011, 1, 168, "no-image.jpg", "Capilano Suspension Bridge", 1, 1 },
                    { 168012, 1, 168, "no-image.jpg", "Lake Louise", 1, 1 },
                    { 168013, 1, 168, "no-image.jpg", "Algonquin Provincial Park", 1, 1 },
                    { 168014, 1, 168, "no-image.jpg", "Fundy Trail Parkway", 1, 1 },
                    { 168015, 1, 168, "no-image.jpg", "Notre-Dame Basilica", 1, 1 },
                    { 168016, 1, 168, "no-image.jpg", "Acadian Forest", 1, 1 },
                    { 168017, 1, 168, "no-image.jpg", "Canadian Rockies", 1, 1 },
                    { 168018, 1, 168, "no-image.jpg", "Victoria", 1, 1 },
                    { 168019, 1, 168, "no-image.jpg", "Halifax", 1, 1 },
                    { 168020, 1, 168, "no-image.jpg", "Burlington", 1, 1 },
                    { 169001, 1, 169, "no-image.jpg", "Mexico City", 1, 1 },
                    { 169002, 1, 169, "no-image.jpg", "Monterrey", 1, 1 },
                    { 169003, 1, 169, "no-image.jpg", "Tulum", 1, 1 },
                    { 169004, 1, 169, "no-image.jpg", "Lake Chapala", 1, 1 },
                    { 170001, 1, 170, "no-image.jpg", "New York City", 1, 1 },
                    { 170002, 1, 170, "no-image.jpg", "San Francisco", 1, 1 },
                    { 170003, 1, 170, "no-image.jpg", "Chicago", 1, 1 },
                    { 170004, 1, 170, "no-image.jpg", "Nashville", 1, 1 },
                    { 170005, 1, 170, "no-image.jpg", "San Diego", 1, 1 },
                    { 170006, 1, 170, "no-image.jpg", "Austin", 1, 1 },
                    { 170007, 1, 170, "no-image.jpg", "Seattle", 1, 1 },
                    { 170008, 1, 170, "no-image.jpg", "Boston", 1, 1 },
                    { 170009, 1, 170, "no-image.jpg", "Los Angeles", 1, 1 },
                    { 170010, 1, 170, "no-image.jpg", "Houston", 1, 1 },
                    { 170011, 1, 170, "no-image.jpg", "Denver", 1, 1 },
                    { 170012, 1, 170, "no-image.jpg", "New Orleans", 1, 1 },
                    { 170013, 1, 170, "no-image.jpg", "Detroit", 1, 1 },
                    { 170014, 1, 170, "no-image.jpg", "Miami", 1, 1 },
                    { 170015, 1, 170, "no-image.jpg", "Yosemite National Park", 1, 1 },
                    { 170016, 1, 170, "no-image.jpg", "Mount Rushmore", 1, 1 },
                    { 170017, 1, 170, "no-image.jpg", "The Grand Canyon", 1, 1 },
                    { 170018, 1, 170, "no-image.jpg", "Washington DC", 1, 1 },
                    { 170019, 1, 170, "no-image.jpg", "Monument Valley", 1, 1 },
                    { 170020, 1, 170, "no-image.jpg", "Golden Gate Bridge", 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 114001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 114002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 115001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 115002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 115003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 115004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 115005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 116001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 116002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 117001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 117002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 117003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 118001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 118002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 118003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 119001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 120001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 120002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 121001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 121002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 122001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 122002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 122003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 123001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 123002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 123003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 124001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 125001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 125002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 125003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 126001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 126002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 127001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 127002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 128001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 129001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 130001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 130002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 130003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 131001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 131002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 132001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 133001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 134001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 135001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 135002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 135003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 136001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 137001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 138001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 138002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 138003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 139001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 140001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 141001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 141002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 142001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 142002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 142003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 142004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 142005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 143001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 144001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 145001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 145002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 145003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 146001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 146002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 146003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 147001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 148001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 149001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 149002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 150001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 151001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 152001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 153001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 154001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 155001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 156001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 157001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 158001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 158002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 159001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 160001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 160002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 160003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 160004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 160005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 161001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 161002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 162001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 163001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 164001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 165001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 165002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 166001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 167001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 167002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 167003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 167004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168007);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168008);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168009);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168010);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168011);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168012);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168013);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168014);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168015);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168016);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168017);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168018);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168019);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 168020);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 169001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 169002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 169003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 169004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170007);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170008);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170009);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170010);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170011);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170012);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170013);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170014);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170015);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170016);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170017);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170018);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170019);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 170020);

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155,
                column: "Name",
                value: "Sao Tome and Príncipe");

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
