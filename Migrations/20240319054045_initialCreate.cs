using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    CountryID = table.Column<int>(type: "int", nullable: false)
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
                    Datetime = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    { 1, "Australia" },
                    { 2, "Asia" },
                    { 3, "Europe" },
                    { 4, "North America" },
                    { 5, "South America" },
                    { 6, "Africa" },
                    { 7, "Antarctica" }
                });

            migrationBuilder.InsertData(
                table: "Trip",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Example Trip: Visiting Family in Sydney" },
                    { 2, "Example Trip: Visiting Tokyo" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "ImageFilename", "Name", "RegionID" },
                values: new object[,]
                {
                    { 1, "australia.jpg", "Australia", 1 },
                    { 2, "china.jpg", "China", 2 },
                    { 3, "india.jpg", "India", 2 },
                    { 4, "japan.jpg", "Japan", 2 },
                    { 5, "malaysia.jpg", "Malaysia", 2 },
                    { 6, "philippines.jpg", "Philippines", 2 },
                    { 7, "singapore.jpg", "Singapore", 2 },
                    { 8, "south-korea.jpg", "South Korea", 2 },
                    { 9, "thailand.jpg", "Thailand", 2 },
                    { 10, "vietnam.jpg", "Vietnam", 2 },
                    { 11, "no-image.jpg", "Belgium", 3 },
                    { 12, "no-image.jpg", "Denmark", 3 },
                    { 13, "no-image.jpg", "Finland", 3 },
                    { 14, "no-image.jpg", "France", 3 },
                    { 15, "no-image.jpg", "Germany", 3 },
                    { 16, "no-image.jpg", "Ireland", 3 },
                    { 17, "no-image.jpg", "Italy", 3 },
                    { 18, "no-image.jpg", "Norway", 3 },
                    { 19, "no-image.jpg", "United Kingdom", 3 },
                    { 20, "no-image.jpg", "Bahamas", 4 },
                    { 21, "no-image.jpg", "Canada", 4 },
                    { 22, "no-image.jpg", "Jamaica", 4 },
                    { 23, "no-image.jpg", "Mexico", 4 },
                    { 24, "no-image.jpg", "United States", 4 },
                    { 25, "no-image.jpg", "Argentina", 5 },
                    { 26, "no-image.jpg", "Brazil", 5 },
                    { 27, "no-image.jpg", "Chile", 5 },
                    { 28, "no-image.jpg", "Ecuador", 5 },
                    { 29, "no-image.jpg", "Peru", 5 },
                    { 30, "no-image.jpg", "Ethiopia", 6 },
                    { 31, "no-image.jpg", "Kenya", 6 },
                    { 32, "no-image.jpg", "Nigeria", 6 },
                    { 33, "no-image.jpg", "Rwanda", 6 },
                    { 34, "no-image.jpg", "South Africa", 6 },
                    { 35, "no-image.jpg", "Zimbabwe", 6 },
                    { 36, "no-image.jpg", "Antarctica", 7 }
                });

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "CountryID", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Adelaide" },
                    { 2, 1, "Brisbane" },
                    { 3, 1, "Canberra" },
                    { 4, 1, "Hobart" },
                    { 5, 1, "Melbourne" },
                    { 6, 1, "Sydney" },
                    { 7, 1, "Perth" },
                    { 8, 2, "Beijing" },
                    { 9, 2, "Shanghai" },
                    { 10, 3, "Mumbai" },
                    { 11, 3, "Kolkata" },
                    { 12, 3, "Hyderabad" },
                    { 13, 4, "Tokyo" },
                    { 14, 4, "Osaka" },
                    { 15, 4, "Hiroshima" },
                    { 16, 5, "Kuala Lumpur" },
                    { 17, 6, "Manila" },
                    { 18, 7, "Singapore" },
                    { 19, 8, "Seoul" },
                    { 20, 9, "Bangkok" },
                    { 21, 9, "Phuket" },
                    { 22, 10, "Ho Chi Minh City" },
                    { 23, 10, "Hanoi" },
                    { 24, 11, "Brussels" },
                    { 25, 11, "Bruges" },
                    { 26, 12, "Copenhagen" },
                    { 27, 13, "Helsinki" },
                    { 28, 14, "Paris" },
                    { 29, 15, "Berlin" },
                    { 30, 16, "Dublin" },
                    { 31, 16, "Galway" },
                    { 32, 17, "Rome" },
                    { 33, 17, "Venice" },
                    { 34, 17, "Florence" },
                    { 35, 18, "Oslo" },
                    { 36, 19, "London" },
                    { 37, 19, "Bristol" },
                    { 38, 19, "Manchester" },
                    { 39, 19, "Birmingham" },
                    { 40, 20, "Nassau" },
                    { 41, 21, "Toronto" },
                    { 42, 21, "Vancouver" },
                    { 43, 22, "Montego Bay" },
                    { 44, 23, "Mexico City" },
                    { 45, 24, "Boston" },
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

            migrationBuilder.InsertData(
                table: "Tripstop",
                columns: new[] { "Id", "Datetime", "DestinationID", "TripID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 19, 16, 40, 45, 216, DateTimeKind.Local).AddTicks(2940), 6, 1 },
                    { 2, new DateTime(2024, 3, 19, 16, 40, 45, 216, DateTimeKind.Local).AddTicks(2966), 5, 1 },
                    { 3, new DateTime(2024, 3, 19, 16, 40, 45, 216, DateTimeKind.Local).AddTicks(2968), 13, 2 },
                    { 4, new DateTime(2024, 3, 19, 16, 40, 45, 216, DateTimeKind.Local).AddTicks(2970), 19, 2 }
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
