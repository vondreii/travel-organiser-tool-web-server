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
                name: "ClimateType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClimateType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PopulationType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopulationType", x => x.Id);
                });

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
                name: "TerrainType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerrainType", x => x.Id);
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
                    ImageFilename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    PopulationTypeID = table.Column<int>(type: "int", nullable: false),
                    ClimateTypeID = table.Column<int>(type: "int", nullable: false),
                    TerrainTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Destination_ClimateType_ClimateTypeID",
                        column: x => x.ClimateTypeID,
                        principalTable: "ClimateType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Destination_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Destination_PopulationType_PopulationTypeID",
                        column: x => x.PopulationTypeID,
                        principalTable: "PopulationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Destination_TerrainType_TerrainTypeID",
                        column: x => x.TerrainTypeID,
                        principalTable: "TerrainType",
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
                table: "ClimateType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sunny" },
                    { 2, "Tropical" },
                    { 3, "Chilly" },
                    { 4, "Snowy" }
                });

            migrationBuilder.InsertData(
                table: "PopulationType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "City" },
                    { 2, "Town" },
                    { 3, "Rural (Non Urban)" }
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
                    { 7, "United Kingdom and Western Europe" },
                    { 8, "Central Europe" },
                    { 9, "Southern Europe" },
                    { 10, "Northern Africa" },
                    { 11, "Subsaharan Africa" },
                    { 12, "North America" },
                    { 13, "Central America" },
                    { 14, "Caribbean" },
                    { 15, "South America" },
                    { 16, "South Pole" },
                    { 17, "Eastern Europe and Former USSR" }
                });

            migrationBuilder.InsertData(
                table: "TerrainType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Major City" },
                    { 2, "Desert" },
                    { 3, "Forest" },
                    { 4, "Cliffs" },
                    { 5, "Hills" },
                    { 6, "Marsh" },
                    { 7, "Farmland" },
                    { 8, "Beach" },
                    { 9, "Coastal" },
                    { 10, "Waterfront" },
                    { 11, "Mountains" }
                });

            migrationBuilder.InsertData(
                table: "Trip",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Example Trip: Visiting Family in Sydney" },
                    { 2, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "Example Trip: Visiting Tokyo" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "ImageFilename", "Name", "RegionID" },
                values: new object[,]
                {
                    { 1, "australia.jpg", "Australia", 1 },
                    { 2, "malaysia.jpg", "Malaysia", 2 },
                    { 3, "philippines.jpg", "Philippines", 2 },
                    { 4, "singapore.jpg", "Singapore", 2 },
                    { 5, "thailand.jpg", "Thailand", 2 },
                    { 6, "vietnam.jpg", "Vietnam", 2 },
                    { 7, "china.jpg", "China", 3 },
                    { 8, "japan.jpg", "Japan", 3 },
                    { 9, "south-korea.jpg", "South Korea", 3 },
                    { 10, "india.jpg", "India", 4 },
                    { 11, "no-image.jpg", "Kuwait", 5 },
                    { 12, "no-image.jpg", "United Arab Emirates", 5 },
                    { 13, "denmark.jpg", "Denmark", 6 },
                    { 14, "finland.jpg", "Finland", 6 },
                    { 15, "norway.jpg", "Norway", 6 },
                    { 16, "united-kingdom.jpg", "United Kingdom", 7 },
                    { 17, "ireland.jpg", "Ireland", 7 },
                    { 18, "no-image.jpg", "Belgium", 8 },
                    { 19, "france.jpg", "France", 8 },
                    { 20, "germany.jpg", "Germany", 8 },
                    { 21, "italy.jpg", "Italy", 9 },
                    { 22, "no-image.jpg", "Russia", 17 },
                    { 23, "no-image.jpg", "Sudan", 10 },
                    { 24, "kenya.jpg", "Kenya", 11 },
                    { 25, "rwanda.jpg", "Rwanda", 11 },
                    { 26, "south-africa.jpg", "South Africa", 11 },
                    { 27, "canada.jpg", "Canada", 12 },
                    { 28, "mexico.jpg", "Mexico", 12 },
                    { 29, "united-states.jpg", "United States", 12 },
                    { 30, "no-image.jpg", "Costa Rica", 13 },
                    { 31, "jamaica.jpg", "Jamaica", 14 },
                    { 32, "brazil.jpg", "Brazil", 15 },
                    { 33, "chile.jpg", "Chile", 15 },
                    { 34, "ecuador.jpg", "Ecuador", 15 },
                    { 35, "peru.jpg", "Peru", 15 },
                    { 36, "no-image.jpg", "Antarctica", 16 }
                });

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "ClimateTypeID", "CountryID", "ImageFilename", "Name", "PopulationTypeID", "TerrainTypeID" },
                values: new object[,]
                {
                    { 1, 1, 1, "adelaide.jpg", "Adelaide", 1, 1 },
                    { 2, 2, 1, "brisbane.jpg", "Brisbane", 1, 1 },
                    { 3, 1, 1, "canberra.jpg", "Canberra", 1, 1 },
                    { 4, 3, 1, "hobart.jpg", "Hobart", 1, 1 },
                    { 5, 3, 1, "melbourne.jpg", "Melbourne", 1, 1 },
                    { 6, 1, 1, "sydney.jpg", "Sydney", 1, 1 },
                    { 7, 1, 1, "perth.jpg", "Perth", 1, 1 },
                    { 8, 2, 2, "kuala-lumpur.jpg", "Kuala Lumpur", 1, 1 },
                    { 9, 2, 3, "manila.jpg", "Manila", 1, 1 },
                    { 10, 2, 4, "singapore.jpg", "Singapore", 1, 1 },
                    { 11, 2, 5, "bangkok.jpg", "Bangkok", 1, 1 },
                    { 12, 2, 5, "phuket.jpg", "Phuket", 1, 1 },
                    { 13, 2, 6, "ho-chi-minh-city.jpg", "Ho Chi Minh City", 1, 1 },
                    { 14, 2, 6, "hanoi.jpg", "Hanoi", 1, 1 },
                    { 15, 1, 7, "beijing.jpg", "Beijing", 1, 1 },
                    { 16, 1, 7, "shanghai.jpg", "Shanghai", 1, 1 },
                    { 17, 3, 8, "tokyo.jpg", "Tokyo", 1, 1 },
                    { 18, 3, 8, "osaka.jpg", "Osaka", 1, 1 },
                    { 19, 3, 8, "hiroshima.jpg", "Hiroshima", 1, 1 },
                    { 20, 3, 9, "seoul.jpg", "Seoul", 1, 1 },
                    { 21, 1, 10, "mumbai.jpg", "Mumbai", 1, 1 },
                    { 22, 1, 10, "kolkata.jpg", "Kolkata", 1, 1 },
                    { 23, 1, 10, "hyderabad.jpg", "Hyderabad", 1, 1 },
                    { 24, 1, 11, "no-image.jpg", "Kuwait City", 1, 1 },
                    { 25, 1, 12, "no-image.jpg", "Dubai", 1, 1 },
                    { 26, 3, 13, "copenhagen.jpg", "Copenhagen", 1, 1 },
                    { 27, 3, 14, "helsinki.jpg", "Helsinki", 1, 1 },
                    { 28, 3, 15, "oslo.jpg", "Oslo", 1, 1 },
                    { 29, 1, 16, "london.jpg", "London", 1, 1 },
                    { 30, 1, 16, "bristol.jpg", "Bristol", 1, 1 },
                    { 31, 1, 16, "manchester.jpg", "Manchester", 1, 1 },
                    { 32, 1, 16, "birmingham.jpg", "Birmingham", 1, 1 },
                    { 33, 3, 17, "dublin.jpg", "Dublin", 1, 1 },
                    { 34, 3, 17, "galway.jpg", "Galway", 1, 1 },
                    { 35, 3, 18, "no-image.jpg", "Bruges", 1, 1 },
                    { 36, 3, 19, "paris.jpg", "Paris", 1, 1 },
                    { 37, 3, 20, "berlin.jpg", "Berlin", 1, 1 },
                    { 38, 1, 21, "rome.jpg", "Rome", 1, 1 },
                    { 39, 1, 21, "venice.jpg", "Venice", 1, 1 },
                    { 40, 1, 21, "florence.jpg", "Florence", 1, 1 },
                    { 41, 3, 22, "no-image.jpg", "Moscow", 1, 1 },
                    { 42, 1, 23, "no-image.jpg", "Kassala", 1, 1 },
                    { 43, 1, 24, "nairobi.jpg", "Nairobi", 1, 1 },
                    { 44, 1, 25, "kigali.jpg", "Kigali", 1, 1 },
                    { 45, 1, 26, "johannesburg.jpg", "Johannesburg", 1, 1 },
                    { 46, 3, 27, "toronto.jpg", "Toronto", 1, 1 },
                    { 47, 3, 27, "vancouver.jpg", "Vancouver", 1, 1 },
                    { 48, 1, 28, "mexico-city.jpg", "Mexico City", 1, 1 },
                    { 49, 3, 29, "boston.jpg", "Boston", 1, 1 },
                    { 50, 3, 29, "chicago.jpg", "Chicago", 1, 1 },
                    { 51, 1, 29, "los-angeles.jpg", "Los Angeles", 1, 1 },
                    { 52, 3, 29, "new-york.jpg", "New York", 1, 1 },
                    { 53, 2, 30, "no-image.jpg", "San Jose", 1, 1 },
                    { 54, 1, 31, "montego-bay.jpg", "Montego Bay", 1, 1 },
                    { 55, 1, 32, "rio-de-janeiro.jpg", "Rio de Janeiro", 1, 1 },
                    { 56, 1, 32, "salvador.jpg", "Salvador", 1, 1 },
                    { 57, 1, 32, "sao-paulo.jpg", "Sao Paulo", 1, 1 },
                    { 58, 3, 33, "santiago.jpg", "Santiago", 3, 1 },
                    { 59, 3, 34, "quito.jpg", "Quito", 1, 1 },
                    { 60, 3, 35, "arequipa.jpg", "Arequipa", 1, 1 },
                    { 61, 4, 36, "mcmurdo-station.jpg", "McMurdo Station", 1, 11 }
                });

            migrationBuilder.InsertData(
                table: "Tripstop",
                columns: new[] { "Id", "DestinationID", "Enddate", "Startdate", "TripID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 2, 2, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 3, 3, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 2 },
                    { 4, 4, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Country_RegionID",
                table: "Country",
                column: "RegionID");

            migrationBuilder.CreateIndex(
                name: "IX_Destination_ClimateTypeID",
                table: "Destination",
                column: "ClimateTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Destination_CountryID",
                table: "Destination",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Destination_PopulationTypeID",
                table: "Destination",
                column: "PopulationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Destination_TerrainTypeID",
                table: "Destination",
                column: "TerrainTypeID");

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
                name: "ClimateType");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "PopulationType");

            migrationBuilder.DropTable(
                name: "TerrainType");

            migrationBuilder.DropTable(
                name: "Region");
        }
    }
}
