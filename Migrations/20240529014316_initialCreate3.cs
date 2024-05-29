using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "ClimateTypeID", "CountryID", "ImageFilename", "Name", "PopulationTypeID", "TerrainTypeID" },
                values: new object[,]
                {
                    { 42001, 1, 42, "no-image.jpg", "Manama", 1, 1 },
                    { 42002, 1, 42, "no-image.jpg", "Muharraq", 1, 1 },
                    { 42003, 1, 42, "no-image.jpg", "Beit Al Quran", 1, 1 },
                    { 42004, 1, 42, "no-image.jpg", "Bahrain Fort", 1, 1 },
                    { 43001, 1, 43, "no-image.jpg", "Tehran", 1, 1 },
                    { 43002, 1, 43, "no-image.jpg", "Isfahan", 1, 1 },
                    { 43003, 1, 43, "no-image.jpg", "Tabriz", 1, 1 },
                    { 43004, 1, 43, "no-image.jpg", "Shahreza", 1, 1 },
                    { 43005, 1, 43, "no-image.jpg", "Yazd", 1, 1 },
                    { 44001, 1, 44, "no-image.jpg", "Baghdad", 1, 1 },
                    { 44002, 1, 44, "no-image.jpg", "Hillah", 1, 1 },
                    { 44003, 1, 44, "no-image.jpg", "Mosul", 1, 1 },
                    { 44004, 1, 44, "no-image.jpg", "Kut", 1, 1 },
                    { 44005, 1, 44, "no-image.jpg", "Holy Shrine Of Imam Hussain", 1, 1 },
                    { 44006, 1, 44, "no-image.jpg", "Citadel of Erbil", 1, 1 },
                    { 45001, 1, 45, "no-image.jpg", "Jerusalem", 1, 1 },
                    { 45002, 1, 45, "no-image.jpg", "Masada National Park", 1, 1 },
                    { 45003, 1, 45, "no-image.jpg", "Church of the Holy Sepulchre", 1, 1 },
                    { 45004, 1, 45, "no-image.jpg", "Baha'i Garden Haifa", 1, 1 },
                    { 46001, 1, 46, "no-image.jpg", "Amman", 1, 1 },
                    { 46002, 1, 46, "no-image.jpg", "Aqaba", 1, 1 },
                    { 46003, 1, 46, "no-image.jpg", "Irbid", 1, 1 },
                    { 46004, 1, 46, "no-image.jpg", "Petra", 1, 1 },
                    { 46005, 1, 46, "no-image.jpg", "Wadi Rum Protected Area", 1, 1 },
                    { 46006, 1, 46, "no-image.jpg", "Roman Theater", 1, 1 },
                    { 47001, 1, 47, "no-image.jpg", "Kuwait City", 1, 1 },
                    { 47002, 1, 47, "no-image.jpg", "Mahboula", 1, 1 },
                    { 47003, 1, 47, "no-image.jpg", "Ahmadi", 1, 1 },
                    { 47004, 1, 47, "no-image.jpg", "Kuwait Towers", 1, 1 },
                    { 48001, 1, 48, "no-image.jpg", "Beirut", 1, 1 },
                    { 48002, 1, 48, "no-image.jpg", "Tripoli", 1, 1 },
                    { 48003, 1, 48, "no-image.jpg", "Sidon", 1, 1 },
                    { 48004, 1, 48, "no-image.jpg", "Byblos", 1, 1 },
                    { 48005, 1, 48, "no-image.jpg", "Zaituna Bay", 1, 1 },
                    { 48006, 1, 48, "no-image.jpg", "Our Lady of Lebanon", 1, 1 },
                    { 49001, 1, 49, "no-image.jpg", "Muscat", 1, 1 },
                    { 49002, 1, 49, "no-image.jpg", "Sur", 1, 1 },
                    { 49003, 1, 49, "no-image.jpg", "Nizwa", 1, 1 },
                    { 49004, 1, 49, "no-image.jpg", "Salalah", 1, 1 },
                    { 49005, 1, 49, "no-image.jpg", "Nizwa Fort", 1, 1 },
                    { 50001, 1, 50, "no-image.jpg", "Gaza", 1, 1 },
                    { 50002, 1, 50, "no-image.jpg", "Hebron", 1, 1 },
                    { 50003, 1, 50, "no-image.jpg", "Dome of the Rock", 1, 1 },
                    { 51001, 1, 51, "no-image.jpg", "Doha", 1, 1 },
                    { 51002, 1, 51, "no-image.jpg", "Souq Waqif", 1, 1 },
                    { 51003, 1, 51, "no-image.jpg", "Katara Cultural Village", 1, 1 },
                    { 52001, 1, 52, "no-image.jpg", "Madinah", 1, 1 },
                    { 52002, 1, 52, "no-image.jpg", "Riyadh", 1, 1 },
                    { 52003, 1, 52, "no-image.jpg", "Jeddah", 1, 1 },
                    { 52004, 1, 52, "no-image.jpg", "Mecca", 1, 1 },
                    { 52005, 1, 52, "no-image.jpg", "Al Masjid an Nabawi", 1, 1 },
                    { 53001, 1, 53, "no-image.jpg", "Damascus", 1, 1 },
                    { 53002, 1, 53, "no-image.jpg", "Hama", 1, 1 },
                    { 53003, 1, 53, "no-image.jpg", "Aleppo", 1, 1 },
                    { 53004, 1, 53, "no-image.jpg", "Umayyad Mosque", 1, 1 },
                    { 53005, 1, 53, "no-image.jpg", "Al-Azm Palace", 1, 1 },
                    { 54001, 1, 54, "no-image.jpg", "Dubai", 1, 1 },
                    { 54002, 1, 54, "no-image.jpg", "Abu Dhabi", 1, 1 },
                    { 54003, 1, 54, "no-image.jpg", "Sharjah", 1, 1 },
                    { 54004, 1, 54, "no-image.jpg", "Burj Khalifa", 1, 1 },
                    { 54005, 1, 54, "no-image.jpg", "Moreeb Dune", 1, 1 },
                    { 55001, 1, 55, "no-image.jpg", "Sanaa", 1, 1 },
                    { 55002, 1, 55, "no-image.jpg", "Aden", 1, 1 },
                    { 55003, 1, 55, "no-image.jpg", "Socotra", 1, 1 },
                    { 55004, 1, 55, "no-image.jpg", "Shoab Beach", 1, 1 },
                    { 56001, 1, 56, "no-image.jpg", "Copenhagen", 1, 1 },
                    { 56002, 1, 56, "no-image.jpg", "Odense", 1, 1 },
                    { 56003, 1, 56, "no-image.jpg", "Rosenborg Castle", 1, 1 },
                    { 56004, 1, 56, "no-image.jpg", "Christiansborg Palace", 1, 1 },
                    { 57001, 1, 57, "no-image.jpg", "Oslo", 1, 1 },
                    { 57002, 1, 57, "no-image.jpg", "Bergen", 1, 1 },
                    { 57003, 1, 57, "no-image.jpg", "Andalsnes", 1, 1 },
                    { 57004, 1, 57, "no-image.jpg", "The Geiranger Fjord", 1, 1 },
                    { 57005, 1, 57, "no-image.jpg", "Pulpit Rock", 1, 1 },
                    { 57006, 1, 57, "no-image.jpg", "Polar Park", 1, 1 },
                    { 58001, 1, 58, "no-image.jpg", "Stockholm", 1, 1 },
                    { 58002, 1, 58, "no-image.jpg", "Gothenburg", 1, 1 },
                    { 58003, 1, 58, "no-image.jpg", "Oresund Bridge", 1, 1 },
                    { 58004, 1, 58, "no-image.jpg", "Abisko National Park", 1, 1 },
                    { 59001, 1, 59, "no-image.jpg", "Torshavn", 1, 1 },
                    { 59002, 1, 59, "no-image.jpg", "Hoyvik", 1, 1 },
                    { 59003, 1, 59, "no-image.jpg", "Mulafossur Waterfall", 1, 1 },
                    { 59004, 1, 59, "no-image.jpg", "The Nordic House", 1, 1 },
                    { 60001, 1, 60, "no-image.jpg", "Helsinki", 1, 1 },
                    { 60002, 1, 60, "no-image.jpg", "Suomenlinna", 1, 1 },
                    { 60003, 1, 60, "no-image.jpg", "Temppeliaukio Church", 1, 1 },
                    { 60004, 1, 60, "no-image.jpg", "Oulanka National Park in Kuusamo", 1, 1 },
                    { 61001, 1, 61, "no-image.jpg", "Reykjavik", 1, 1 },
                    { 61002, 1, 61, "no-image.jpg", "Kopavogur", 1, 1 },
                    { 61003, 1, 61, "no-image.jpg", "Blue Lagoon", 1, 1 },
                    { 61004, 1, 61, "no-image.jpg", "Thingvellir National Park", 1, 1 },
                    { 62001, 1, 62, "no-image.jpg", "Nuuk", 1, 1 },
                    { 62002, 1, 62, "no-image.jpg", "Northeast Greenland National Park", 1, 1 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 42001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 42002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 42003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 42004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 43001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 43002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 43003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 43004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 43005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 44001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 44002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 44003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 44004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 44005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 44006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 45001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 45002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 45003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 45004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 46001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 46002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 46003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 46004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 46005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 46006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 47001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 47002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 47003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 47004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 48001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 48002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 48003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 48004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 48005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 48006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 49001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 49002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 49003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 49004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 49005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 50001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 50002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 50003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 51001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 51002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 51003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 52001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 52002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 52003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 52004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 52005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 53001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 53002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 53003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 53004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 53005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 54001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 54002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 54003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 54004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 54005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 55001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 55002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 55003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 55004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 56001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 56002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 56003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 56004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 57001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 57002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 57003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 57004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 57005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 57006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 58001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 58002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 58003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 58004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 59001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 59002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 59003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 59004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 60001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 60002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 60003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 60004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 61001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 61002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 61003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 61004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 62001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 62002);

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
