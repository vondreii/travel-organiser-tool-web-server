using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Location_LocationID",
                table: "Trip");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "Trip",
                newName: "DestinationID");

            migrationBuilder.RenameIndex(
                name: "IX_Trip_LocationID",
                table: "Trip",
                newName: "IX_Trip_DestinationID");

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

            migrationBuilder.CreateIndex(
                name: "IX_Destination_CountryID",
                table: "Destination",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Destination_DestinationID",
                table: "Trip",
                column: "DestinationID",
                principalTable: "Destination",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Destination_DestinationID",
                table: "Trip");

            migrationBuilder.DropTable(
                name: "Destination");

            migrationBuilder.RenameColumn(
                name: "DestinationID",
                table: "Trip",
                newName: "LocationID");

            migrationBuilder.RenameIndex(
                name: "IX_Trip_DestinationID",
                table: "Trip",
                newName: "IX_Trip_LocationID");

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Location",
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

            migrationBuilder.CreateIndex(
                name: "IX_Location_CountryID",
                table: "Location",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Location_LocationID",
                table: "Trip",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
