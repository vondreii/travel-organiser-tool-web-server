using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionID = table.Column<int>(type: "int", nullable: false),
                    ImageFilename = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Country_Region_RegionID",
                        column: x => x.RegionID,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Destination",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    ImageFilename = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Destination_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tripstop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripID = table.Column<int>(type: "int", nullable: false),
                    DestinationID = table.Column<int>(type: "int", nullable: false),
                    Startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enddate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tripstop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tripstop_Destination_DestinationID",
                        column: x => x.DestinationID,
                        principalTable: "Destination",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tripstop_Trip_TripID",
                        column: x => x.TripID,
                        principalTable: "Trip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Oceania" },
                    { 2, "South East Asia" },
                    { 3, "East Asia" },
                    { 4, "South Asia" },
                    { 5, "Middle East" },
                    { 6, "Scandinavia" },
                    { 7, "United Kingdom" },
                    { 8, "Western Europe" },
                    { 9, "Southern Europe" },
                    { 10, "Northern Africa" },
                    { 11, "Subsaharan Africa" },
                    { 12, "North America" },
                    { 13, "Central America" },
                    { 14, "Caribbean" },
                    { 15, "South America" },
                    { 16, "Polar Regions" }
                });

            migrationBuilder.InsertData(
                table: "Trip",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Example Trip: Visiting Family in Sydney" },
                    { 2, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Example Trip: Visiting Tokyo" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "ImageFilename", "Name", "RegionID" },
                values: new object[,]
                {
                    { 1, "australia.jpg", "Australia", 1 },
                    { 2, "no-image.jpg", "New Zealand", 1 },
                    { 3, "no-image.jpg", "Solomon Islands", 1 },
                    { 4, "no-image.jpg", "Cook Islands", 1 },
                    { 5, "no-image.jpg", "Papua New Guinea", 1 },
                    { 6, "no-image.jpg", "Fiji", 1 },
                    { 7, "no-image.jpg", "Micronesia", 1 },
                    { 8, "no-image.jpg", "Samoa", 1 },
                    { 9, "no-image.jpg", "Vanuatu", 1 },
                    { 10, "no-image.jpg", "Brunei", 2 },
                    { 11, "no-image.jpg", "Burma", 2 },
                    { 12, "no-image.jpg", "Cambodia", 2 },
                    { 13, "no-image.jpg", "Timor-Leste", 2 },
                    { 14, "no-image.jpg", "Indonesia", 2 },
                    { 15, "no-image.jpg", "Laos", 2 },
                    { 16, "malaysia.jpg", "Malaysia", 2 },
                    { 17, "philippines.jpg", "Philippines", 2 },
                    { 18, "singapore.jpg", "Singapore", 2 },
                    { 19, "thailand.jpg", "Thailand", 2 },
                    { 20, "vietnam.jpg", "Vietnam", 2 },
                    { 21, "china.jpg", "China", 3 },
                    { 22, "japan.jpg", "Japan", 3 },
                    { 23, "no-image.jpg", "Mongolia", 3 },
                    { 24, "south-korea.jpg", "South Korea", 3 },
                    { 25, "no-image.jpg", "North Korea", 3 },
                    { 26, "no-image.jpg", "Taiwan", 3 },
                    { 27, "no-image.jpg", "Macao", 3 },
                    { 28, "no-image.jpg", "Hong Kong", 3 },
                    { 29, "no-image.jpg", "Afghanistan", 4 },
                    { 30, "no-image.jpg", "Bangladesh", 4 },
                    { 31, "no-image.jpg", "Bhutan", 4 },
                    { 32, "india.jpg", "India", 4 },
                    { 33, "no-image.jpg", "Nepal", 4 },
                    { 34, "no-image.jpg", "Maldives", 4 },
                    { 35, "no-image.jpg", "Pakistan", 4 },
                    { 36, "no-image.jpg", "Sri Lanka", 4 }
                });

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "CountryID", "ImageFilename", "Name" },
                values: new object[,]
                {
                    { 1, 1, "adelaide.jpg", "Adelaide" },
                    { 2, 1, "brisbane.jpg", "Brisbane" },
                    { 3, 1, "canberra.jpg", "Canberra" },
                    { 4, 1, "hobart.jpg", "Hobart" },
                    { 5, 1, "melbourne.jpg", "Melbourne" },
                    { 6, 1, "sydney.jpg", "Sydney" },
                    { 7, 1, "perth.jpg", "Perth" },
                    { 8, 1, "no-image.jpg", "Newcastle" },
                    { 9, 1, "no-image.jpg", "Central Coast" },
                    { 10, 1, "no-image.jpg", "Hunter Valley" },
                    { 11, 1, "no-image.jpg", "Nelson Bay" },
                    { 12, 1, "no-image.jpg", "Port Macquarie" }
                });

            migrationBuilder.InsertData(
                table: "Tripstop",
                columns: new[] { "Id", "DestinationID", "Enddate", "Startdate", "TripID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 2, 2, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 3, 3, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), 2 },
                    { 4, 4, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Country_RegionID",
                table: "Country",
                column: "RegionID");

            migrationBuilder.CreateIndex(
                name: "IX_Destination_CountryID",
                table: "Destination",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Tripstop_DestinationID",
                table: "Tripstop",
                column: "DestinationID");

            migrationBuilder.CreateIndex(
                name: "IX_Tripstop_TripID",
                table: "Tripstop",
                column: "TripID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tripstop");

            migrationBuilder.DropTable(
                name: "Destination");

            migrationBuilder.DropTable(
                name: "Trip");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Region");
        }
    }
}
