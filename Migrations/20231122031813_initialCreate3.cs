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
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Trip");

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Trip",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateOrProvince = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false)
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
                columns: new[] { "Id", "City", "CountryID", "StateOrProvince" },
                values: new object[,]
                {
                    { 1, "Sydney", 1, "NSW" },
                    { 2, "Tokyo", 2, "Tokyo metropolitan prefecture" }
                });

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocationID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LocationID", "Name" },
                values: new object[] { 2, "Visiting Tokyo" });

            migrationBuilder.CreateIndex(
                name: "IX_Trip_LocationID",
                table: "Trip",
                column: "LocationID");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Location_LocationID",
                table: "Trip");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Trip_LocationID",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Trip");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Trip",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 1,
                column: "Location",
                value: "Sydney");

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Location", "Name" },
                values: new object[] { "London", "Visiting the UK" });
        }
    }
}
