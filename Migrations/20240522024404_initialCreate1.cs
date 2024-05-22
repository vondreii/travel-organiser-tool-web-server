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
                    { 1, "Major Cities" },
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
                    { 1, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Example Trip: Visiting Family in Sydney" },
                    { 2, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Example Trip: Visiting Tokyo" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "ImageFilename", "Name", "RegionID" },
                values: new object[,]
                {
                    { 1, "australia.jpg", "Australia", 1 },
                    { 2, "no-image.jpg", "Cook Islands", 1 },
                    { 3, "no-image.jpg", "Fiji", 1 },
                    { 4, "no-image.jpg", "Kiribati", 1 },
                    { 5, "no-image.jpg", "Marshall Islands", 1 },
                    { 6, "no-image.jpg", "Micronesia", 1 },
                    { 7, "no-image.jpg", "Nauru", 1 },
                    { 8, "no-image.jpg", "New Zealand", 1 },
                    { 9, "no-image.jpg", "Papua New Guinea", 1 },
                    { 10, "no-image.jpg", "Samoa", 1 },
                    { 11, "no-image.jpg", "Solomon Islands", 1 },
                    { 12, "no-image.jpg", "Tonga", 1 },
                    { 13, "no-image.jpg", "Vanuatu", 1 },
                    { 14, "no-image.jpg", "Brunei", 2 },
                    { 15, "no-image.jpg", "Burma", 2 },
                    { 16, "no-image.jpg", "Cambodia", 2 },
                    { 17, "no-image.jpg", "Timor-Leste", 2 },
                    { 18, "no-image.jpg", "Indonesia", 2 },
                    { 19, "no-image.jpg", "Laos", 2 },
                    { 20, "malaysia.jpg", "Malaysia", 2 },
                    { 21, "no-image.jpg", "Myanmar", 2 },
                    { 22, "philippines.jpg", "Philippines", 2 },
                    { 23, "singapore.jpg", "Singapore", 2 },
                    { 24, "thailand.jpg", "Thailand", 2 },
                    { 25, "vietnam.jpg", "Vietnam", 2 },
                    { 26, "china.jpg", "China", 3 },
                    { 27, "japan.jpg", "Japan", 3 },
                    { 28, "no-image.jpg", "Mongolia", 3 },
                    { 29, "south-korea.jpg", "South Korea", 3 },
                    { 30, "no-image.jpg", "North Korea", 3 },
                    { 31, "no-image.jpg", "Taiwan", 3 },
                    { 32, "no-image.jpg", "Macao", 3 },
                    { 33, "no-image.jpg", "Hong Kong", 3 },
                    { 34, "no-image.jpg", "Afghanistan", 4 },
                    { 35, "no-image.jpg", "Bangladesh", 4 },
                    { 36, "no-image.jpg", "Bhutan", 4 },
                    { 37, "india.jpg", "India", 4 },
                    { 38, "no-image.jpg", "Nepal", 4 },
                    { 39, "no-image.jpg", "Maldives", 4 },
                    { 40, "no-image.jpg", "Pakistan", 4 },
                    { 41, "no-image.jpg", "Sri Lanka", 4 },
                    { 42, "no-image.jpg", "Bahrain", 5 },
                    { 43, "no-image.jpg", "Iran", 5 },
                    { 44, "no-image.jpg", "Iraq", 5 },
                    { 45, "no-image.jpg", "Israel", 5 },
                    { 46, "no-image.jpg", "Jordan", 5 },
                    { 47, "no-image.jpg", "Kuwait", 5 },
                    { 48, "no-image.jpg", "Lebanon", 5 },
                    { 49, "no-image.jpg", "Oman", 5 },
                    { 50, "no-image.jpg", "Palestine", 5 },
                    { 51, "no-image.jpg", "Qatar", 5 },
                    { 52, "no-image.jpg", "Saudi Arabia", 5 },
                    { 53, "no-image.jpg", "Syria", 5 },
                    { 54, "no-image.jpg", "United Arab Emirates", 5 },
                    { 55, "no-image.jpg", "Yemen", 5 },
                    { 56, "denmark.jpg", "Denmark", 6 },
                    { 57, "norway.jpg", "Norway", 6 },
                    { 58, "no-image.jpg", "Sweden", 6 },
                    { 59, "no-image.jpg", "Faroe Islands", 6 },
                    { 60, "finland.jpg", "Finland", 6 },
                    { 61, "no-image.jpg", "Iceland", 6 },
                    { 62, "no-image.jpg", "Greenland", 6 },
                    { 63, "england.jpg", "England", 7 },
                    { 64, "no-image.jpg", "Scotland", 7 },
                    { 65, "no-image.jpg", "Wales", 7 },
                    { 66, "no-image.jpg", "North Ireland", 7 },
                    { 67, "ireland.jpg", "Republic of Ireland", 7 },
                    { 68, "no-image.jpg", "Austria", 8 },
                    { 69, "no-image.jpg", "Bulgaria", 8 },
                    { 70, "no-image.jpg", "Belgium", 8 },
                    { 71, "no-image.jpg", "Czech Republic", 8 },
                    { 72, "france.jpg", "France", 8 },
                    { 73, "germany.jpg", "Germany", 8 },
                    { 74, "no-image.jpg", "Hungary", 8 },
                    { 75, "no-image.jpg", "Liechtenstein", 8 },
                    { 76, "no-image.jpg", "Lithuania", 8 },
                    { 77, "no-image.jpg", "Luxembourg", 8 },
                    { 78, "no-image.jpg", "Netherlands", 8 },
                    { 79, "no-image.jpg", "Poland", 8 },
                    { 80, "no-image.jpg", "Romania", 8 },
                    { 81, "no-image.jpg", "Serbia", 8 },
                    { 82, "no-image.jpg", "Slovakia", 8 },
                    { 83, "no-image.jpg", "Switzerland", 8 },
                    { 84, "no-image.jpg", "Albania", 9 },
                    { 85, "no-image.jpg", "Andorra", 9 },
                    { 86, "no-image.jpg", "Bosnia", 9 },
                    { 87, "no-image.jpg", "Croatia", 9 },
                    { 88, "no-image.jpg", "Cyprus", 9 },
                    { 89, "no-image.jpg", "Greece", 9 },
                    { 90, "italy.jpg", "Italy", 9 },
                    { 91, "no-image.jpg", "Kosovo", 9 },
                    { 92, "no-image.jpg", "Malta", 9 },
                    { 93, "no-image.jpg", "Monaco", 9 },
                    { 94, "no-image.jpg", "Montenegro", 9 },
                    { 95, "no-image.jpg", "North Macedonia", 9 },
                    { 96, "no-image.jpg", "Portugal", 9 },
                    { 97, "no-image.jpg", "Slovenia", 9 },
                    { 98, "no-image.jpg", "Spain", 9 },
                    { 99, "no-image.jpg", "Armenia", 17 },
                    { 100, "no-image.jpg", "Azerbaijan", 17 },
                    { 101, "no-image.jpg", "Belarus", 17 },
                    { 102, "no-image.jpg", "Estonia", 17 },
                    { 103, "no-image.jpg", "Georgia", 17 },
                    { 104, "no-image.jpg", "Kazakhstan", 17 },
                    { 105, "no-image.jpg", "Kyrgyzstan", 17 },
                    { 106, "no-image.jpg", "Latvia", 17 },
                    { 107, "no-image.jpg", "Lithuania", 17 },
                    { 108, "no-image.jpg", "Moldova", 17 },
                    { 109, "no-image.jpg", "Russia", 17 },
                    { 110, "no-image.jpg", "Tajikistan", 17 },
                    { 111, "no-image.jpg", "Turkmenistan", 17 },
                    { 112, "no-image.jpg", "Ukraine", 17 },
                    { 113, "no-image.jpg", "Uzbekistan", 17 },
                    { 114, "no-image.jpg", "Algeria", 10 },
                    { 115, "no-image.jpg", "Egypt", 10 },
                    { 116, "no-image.jpg", "Libya", 10 },
                    { 117, "no-image.jpg", "Morocco", 10 },
                    { 118, "no-image.jpg", "Sudan", 10 },
                    { 119, "no-image.jpg", "Tunisia", 10 },
                    { 120, "no-image.jpg", "Angola", 11 },
                    { 121, "no-image.jpg", "Benin", 11 },
                    { 122, "no-image.jpg", "Botswana", 11 },
                    { 123, "no-image.jpg", "Burkina Faso", 11 },
                    { 124, "no-image.jpg", "Burundi", 11 },
                    { 125, "no-image.jpg", "Cameroon", 11 },
                    { 126, "no-image.jpg", "Cape Verde", 11 },
                    { 127, "no-image.jpg", "Central African Republic", 11 },
                    { 128, "no-image.jpg", "Chad", 11 },
                    { 129, "no-image.jpg", "Comoros", 11 },
                    { 130, "no-image.jpg", "Democratic Republic of the Congo", 11 },
                    { 131, "no-image.jpg", "Djibouti", 11 },
                    { 132, "no-image.jpg", "Equatorial Guinea", 11 },
                    { 133, "no-image.jpg", "Eritrea", 11 },
                    { 134, "no-image.jpg", "Eswatini", 11 },
                    { 135, "ethiopia.jpg", "Ethiopia", 11 },
                    { 136, "no-image.jpg", "Gabon", 11 },
                    { 137, "no-image.jpg", "Gambia", 11 },
                    { 138, "no-image.jpg", "Ghana", 11 },
                    { 139, "no-image.jpg", "Guinea", 11 },
                    { 140, "no-image.jpg", "Guinea - Bissau", 11 },
                    { 141, "no-image.jpg", "Ivory Coast", 11 },
                    { 142, "kenya.jpg", "Kenya", 11 },
                    { 143, "no-image.jpg", "Lesotho", 11 },
                    { 144, "no-image.jpg", "Liberia", 11 },
                    { 145, "no-image.jpg", "Madagascar", 11 },
                    { 146, "no-image.jpg", "Malawi", 11 },
                    { 147, "no-image.jpg", "Mali", 11 },
                    { 148, "no-image.jpg", "Mauritania", 11 },
                    { 149, "no-image.jpg", "Mauritius", 11 },
                    { 150, "no-image.jpg", "Mozambique", 11 },
                    { 151, "no-image.jpg", "Namibia", 11 },
                    { 152, "no-image.jpg", "Niger", 11 },
                    { 153, "nigeria.jpg", "Nigeria", 11 },
                    { 154, "rwanda.jpg", "Rwanda", 11 },
                    { 155, "no-image.jpg", "Sao Tome and Príncipe", 11 },
                    { 156, "no-image.jpg", "Senegal", 11 },
                    { 157, "no-image.jpg", "Seychelles", 11 },
                    { 158, "no-image.jpg", "Sierra Leone", 11 },
                    { 159, "no-image.jpg", "Somalia", 11 },
                    { 160, "south-africa.jpg", "South Africa", 11 },
                    { 161, "no-image.jpg", "South Sudan", 11 },
                    { 162, "no-image.jpg", "Sudan", 11 },
                    { 163, "no-image.jpg", "Tanzania", 11 },
                    { 164, "no-image.jpg", "Togo", 11 },
                    { 165, "no-image.jpg", "Uganda", 11 },
                    { 166, "no-image.jpg", "Zambia", 11 },
                    { 167, "zimbabwe.jpg", "Zimbabwe", 11 },
                    { 168, "canada.jpg", "Canada", 12 },
                    { 169, "mexico.jpg", "Mexico", 12 },
                    { 170, "united-states.jpg", "United States", 12 },
                    { 171, "no-image.jpg", "Belize", 13 },
                    { 172, "no-image.jpg", "Costa Rica", 13 },
                    { 173, "no-image.jpg", "El Salvador", 13 },
                    { 174, "no-image.jpg", "Guatemala", 13 },
                    { 175, "no-image.jpg", "Honduras", 13 },
                    { 176, "no-image.jpg", "Nicaragua", 13 },
                    { 177, "no-image.jpg", "Panama", 13 },
                    { 178, "no-image.jpg", "Aruba", 14 },
                    { 179, "no-image.jpg", "Anguilla", 14 },
                    { 180, "no-image.jpg", "Antigua and Barbuda", 14 },
                    { 181, "no-image.jpg", "Bahamas", 14 },
                    { 182, "no-image.jpg", "Barbados", 14 },
                    { 183, "no-image.jpg", "Bermuda", 14 },
                    { 184, "no-image.jpg", "Cuba", 14 },
                    { 185, "no-image.jpg", "Dominica", 14 },
                    { 186, "no-image.jpg", "Dominican Republic", 14 },
                    { 187, "no-image.jpg", "Haiti", 14 },
                    { 188, "jamaica.jpg", "Jamaica", 14 },
                    { 189, "no-image.jpg", "Puerto Rico", 14 },
                    { 190, "no-image.jpg", "St. Kitts and Nevis", 14 },
                    { 191, "no-image.jpg", "St. Lucia", 14 },
                    { 192, "no-image.jpg", "St. Vincent and the Grenadines", 14 },
                    { 193, "no-image.jpg", "Grenada", 14 },
                    { 194, "no-image.jpg", "Argentina", 15 },
                    { 195, "no-image.jpg", "Bolivia", 15 },
                    { 196, "brazil.jpg", "Brazil", 15 },
                    { 197, "chile.jpg", "Chile", 15 },
                    { 198, "no-image.jpg", "Colombia", 15 },
                    { 199, "ecuador.jpg", "Ecuador", 15 },
                    { 200, "no-image.jpg", "Guyana", 15 },
                    { 201, "no-image.jpg", "Paraguay", 15 },
                    { 202, "peru.jpg", "Peru", 15 },
                    { 203, "no-image.jpg", "Suriname", 15 },
                    { 204, "no-image.jpg", "Uruguay", 15 },
                    { 205, "no-image.jpg", "Venezuela", 15 },
                    { 206, "no-image.jpg", "Trinidad and Tobago", 15 },
                    { 207, "no-image.jpg", "Antarctica", 16 }
                });

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "ClimateTypeID", "CountryID", "ImageFilename", "Name", "PopulationTypeID", "TerrainTypeID" },
                values: new object[,]
                {
                    { 1001, 1, 1, "sydney.jpg", "Sydney", 1, 1 },
                    { 1002, 1, 1, "no-image.jpg", "Newcastle", 1, 1 },
                    { 1003, 1, 1, "no-image.jpg", "Central Coast", 1, 1 },
                    { 1004, 1, 1, "no-image.jpg", "Goulburn", 1, 1 },
                    { 1005, 1, 1, "no-image.jpg", "The Entrance", 1, 1 },
                    { 1006, 1, 1, "no-image.jpg", "Long Jetty", 1, 1 },
                    { 1007, 1, 1, "no-image.jpg", "Nelson Bay", 1, 1 },
                    { 1008, 1, 1, "no-image.jpg", "Port Macquarie", 1, 1 },
                    { 1009, 1, 1, "no-image.jpg", "Coffs Harbour", 1, 1 },
                    { 1010, 1, 1, "no-image.jpg", "Sawtell", 1, 1 },
                    { 1011, 1, 1, "no-image.jpg", "Dubbo", 1, 1 },
                    { 1012, 1, 1, "no-image.jpg", "Tamworth", 1, 1 },
                    { 1013, 1, 1, "no-image.jpg", "Lithgow", 1, 1 },
                    { 1014, 1, 1, "no-image.jpg", "Three sisters", 1, 1 },
                    { 1015, 1, 1, "no-image.jpg", "Katoomba", 1, 1 },
                    { 1016, 1, 1, "no-image.jpg", "Leura Falls", 1, 1 },
                    { 1017, 1, 1, "no-image.jpg", "Wollongong", 1, 1 },
                    { 1018, 1, 1, "no-image.jpg", "Orange", 1, 1 },
                    { 1019, 1, 1, "no-image.jpg", "Bathurst", 1, 1 },
                    { 1020, 1, 1, "no-image.jpg", "Kangaroo Valley", 1, 1 },
                    { 1021, 1, 1, "no-image.jpg", "Jervis Bay", 1, 1 },
                    { 1022, 1, 1, "no-image.jpg", "Cronulla", 1, 1 },
                    { 1023, 1, 1, "no-image.jpg", "Byron Bay", 1, 1 },
                    { 1024, 1, 1, "no-image.jpg", "Mount Kosciuszko", 1, 1 },
                    { 1025, 1, 1, "no-image.jpg", "Thredbo", 1, 1 },
                    { 1026, 1, 1, "no-image.jpg", "Lismore", 1, 1 },
                    { 1027, 1, 1, "no-image.jpg", "Broken Hill", 1, 1 },
                    { 1028, 1, 1, "melbourne.jpg", "Melbourne", 1, 1 },
                    { 1029, 1, 1, "no-image.jpg", "Geelong", 1, 1 },
                    { 1030, 1, 1, "no-image.jpg", "Bendigo", 1, 1 },
                    { 1031, 1, 1, "no-image.jpg", "Twelve Apostles", 1, 1 },
                    { 1032, 1, 1, "no-image.jpg", "Apollo Bay", 1, 1 },
                    { 1033, 1, 1, "no-image.jpg", "Ballarat", 1, 1 },
                    { 1034, 1, 1, "no-image.jpg", "Traralgon", 1, 1 },
                    { 1035, 1, 1, "no-image.jpg", "Port Albert", 1, 1 },
                    { 1036, 1, 1, "no-image.jpg", "Mildura", 1, 1 },
                    { 1037, 1, 1, "no-image.jpg", "Shepparton", 1, 1 },
                    { 1038, 1, 1, "no-image.jpg", "Wodonga", 1, 1 },
                    { 1039, 1, 1, "no-image.jpg", "Warrnambool", 1, 1 },
                    { 1040, 1, 1, "adelaide.jpg", "Adelaide", 1, 1 },
                    { 1041, 1, 1, "no-image.jpg", "Adelaide Hills", 1, 1 },
                    { 1042, 1, 1, "no-image.jpg", "Clare Valley", 1, 1 },
                    { 1043, 1, 1, "no-image.jpg", "Eyre Peninsula", 1, 1 },
                    { 1044, 1, 1, "no-image.jpg", "Flinders Ranges", 1, 1 },
                    { 1045, 1, 1, "no-image.jpg", "Kangaroo Island", 1, 1 },
                    { 1046, 1, 1, "no-image.jpg", "Limestone Coast", 1, 1 },
                    { 1047, 1, 1, "no-image.jpg", "Murray River", 1, 1 },
                    { 1048, 1, 1, "no-image.jpg", "Port Augusta", 1, 1 },
                    { 1049, 1, 1, "no-image.jpg", "Whyalla", 1, 1 },
                    { 1050, 1, 1, "no-image.jpg", "Port Lincoln", 1, 1 },
                    { 1051, 1, 1, "no-image.jpg", "Victor Harbor", 1, 1 },
                    { 1052, 1, 1, "no-image.jpg", "Coober Pedy", 1, 1 },
                    { 1053, 1, 1, "no-image.jpg", "Port Pirie", 1, 1 },
                    { 1054, 1, 1, "brisbane.jpg", "Brisbane", 1, 1 },
                    { 1055, 1, 1, "no-image.jpg", "Daintree Rainforest", 1, 1 },
                    { 1056, 1, 1, "no-image.jpg", "Gold Coast", 1, 1 },
                    { 1057, 1, 1, "no-image.jpg", "Great Barrier Reef", 1, 1 },
                    { 1058, 1, 1, "no-image.jpg", "Cairns", 1, 1 },
                    { 1059, 1, 1, "no-image.jpg", "Rainbow Beach", 1, 1 },
                    { 1060, 1, 1, "no-image.jpg", "Toowoomba", 1, 1 },
                    { 1061, 1, 1, "no-image.jpg", "Rockhampton City", 1, 1 },
                    { 1062, 1, 1, "no-image.jpg", "Mount Isa City", 1, 1 },
                    { 1063, 1, 1, "no-image.jpg", "Bundaberg", 1, 1 },
                    { 1064, 1, 1, "no-image.jpg", "Hervey Bay", 1, 1 },
                    { 1065, 1, 1, "no-image.jpg", "Mackay", 1, 1 },
                    { 1066, 1, 1, "no-image.jpg", "Noosa Heads", 1, 1 },
                    { 1067, 1, 1, "no-image.jpg", "Birdsville", 1, 1 },
                    { 1068, 1, 1, "no-image.jpg", "Whitsundays Islands", 1, 1 },
                    { 1069, 1, 1, "no-image.jpg", "Fraser Island", 1, 1 },
                    { 1070, 1, 1, "no-image.jpg", "Cape York Peninsula", 1, 1 },
                    { 1071, 1, 1, "no-image.jpg", "Townsville", 1, 1 },
                    { 1072, 1, 1, "canberra.jpg", "Canberra", 1, 1 },
                    { 1073, 1, 1, "hobart.jpg", "Hobart", 1, 1 },
                    { 1074, 1, 1, "no-image.jpg", "Port Arthur", 1, 1 },
                    { 1075, 1, 1, "no-image.jpg", "Flinders Island", 1, 1 },
                    { 1076, 1, 1, "no-image.jpg", "Cape Barren Island", 1, 1 },
                    { 1077, 1, 1, "no-image.jpg", "King Island", 1, 1 },
                    { 1078, 1, 1, "no-image.jpg", "Launceston", 1, 1 },
                    { 1079, 1, 1, "no-image.jpg", "Devonport", 1, 1 },
                    { 1080, 1, 1, "no-image.jpg", "Mt Wellington", 1, 1 },
                    { 1081, 1, 1, "no-image.jpg", "Darwin", 1, 1 },
                    { 1082, 1, 1, "no-image.jpg", "Tennant Creek", 1, 1 },
                    { 1083, 1, 1, "no-image.jpg", "Litchfield National Park", 1, 1 },
                    { 1084, 1, 1, "no-image.jpg", "Mary River", 1, 1 },
                    { 1085, 1, 1, "no-image.jpg", "Palmerston", 1, 1 },
                    { 1086, 1, 1, "no-image.jpg", "Alice Springs", 1, 1 },
                    { 1087, 1, 1, "no-image.jpg", "Uluru", 1, 1 },
                    { 1088, 1, 1, "perth.jpg", "Perth", 1, 1 },
                    { 1089, 1, 1, "no-image.jpg", "Broome", 1, 1 },
                    { 1090, 1, 1, "no-image.jpg", "Lake Hillier", 1, 1 },
                    { 1091, 1, 1, "no-image.jpg", "Albany", 1, 1 },
                    { 1092, 1, 1, "no-image.jpg", "Port Hedland", 1, 1 },
                    { 1093, 1, 1, "no-image.jpg", "Geraldton", 1, 1 },
                    { 1094, 1, 1, "no-image.jpg", "Busselton", 1, 1 },
                    { 1095, 1, 1, "no-image.jpg", "Esperance", 1, 1 },
                    { 1096, 1, 1, "no-image.jpg", "Margaret River", 1, 1 },
                    { 1097, 1, 1, "no-image.jpg", "Fremantle", 1, 1 },
                    { 1098, 1, 1, "no-image.jpg", "Wave Rock", 1, 1 },
                    { 1099, 1, 1, "no-image.jpg", "Kalgoorlie", 1, 1 },
                    { 1100, 1, 1, "no-image.jpg", "Exmouth", 1, 1 },
                    { 2001, 1, 2, "no-image.jpg", "Aitutaki Lagoon", 1, 1 },
                    { 2002, 1, 2, "no-image.jpg", "One Foot Island", 1, 1 },
                    { 2003, 1, 2, "no-image.jpg", "Maire Nui Gardens", 1, 1 },
                    { 2004, 1, 2, "no-image.jpg", "Muri Lagoon", 1, 1 },
                    { 2005, 1, 2, "no-image.jpg", "Titikaveka Beach", 1, 1 },
                    { 2006, 1, 2, "no-image.jpg", "Punanga Nui", 1, 1 },
                    { 2007, 1, 2, "no-image.jpg", "Muri Night Market", 1, 1 },
                    { 2008, 1, 2, "no-image.jpg", "Aroa Marine Reserve", 1, 1 },
                    { 2009, 1, 2, "no-image.jpg", "Manuea", 1, 1 },
                    { 2010, 1, 2, "no-image.jpg", "Atiu", 1, 1 },
                    { 2011, 1, 2, "no-image.jpg", "Mitiaro", 1, 1 },
                    { 2012, 1, 2, "no-image.jpg", "Rarotonga", 1, 1 },
                    { 2013, 1, 2, "no-image.jpg", "Palmerston", 1, 1 },
                    { 2014, 1, 2, "no-image.jpg", "Nassau", 1, 1 },
                    { 3001, 1, 3, "no-image.jpg", "Nadi", 1, 1 },
                    { 3002, 1, 3, "no-image.jpg", "Suva", 1, 1 },
                    { 3003, 1, 3, "no-image.jpg", "Lautoka", 1, 1 },
                    { 3004, 1, 3, "no-image.jpg", "Ba", 1, 1 },
                    { 3005, 1, 3, "no-image.jpg", "Labasa", 1, 1 },
                    { 4001, 1, 4, "no-image.jpg", "Tarawa", 1, 1 },
                    { 4002, 1, 4, "no-image.jpg", "Kiritimati", 1, 1 },
                    { 4003, 1, 4, "no-image.jpg", "Tabuaeran", 1, 1 },
                    { 4004, 1, 4, "no-image.jpg", "Nikumaroro Island", 1, 1 },
                    { 4005, 1, 4, "no-image.jpg", "Kanton Island", 1, 1 },
                    { 5001, 1, 5, "no-image.jpg", "Bikini Atoll", 1, 1 },
                    { 5002, 1, 5, "no-image.jpg", "Kwajalein Atoll", 1, 1 },
                    { 5003, 1, 5, "no-image.jpg", "Enewetak Atoll", 1, 1 },
                    { 5004, 1, 5, "no-image.jpg", "Jaluit Atoll", 1, 1 },
                    { 5005, 1, 5, "no-image.jpg", "Ralik Chain", 1, 1 },
                    { 6001, 1, 6, "no-image.jpg", "Weno", 1, 1 },
                    { 6002, 1, 6, "no-image.jpg", "Tofol", 1, 1 },
                    { 6003, 1, 6, "no-image.jpg", "Colonia", 1, 1 },
                    { 6004, 1, 6, "no-image.jpg", "Kolonia", 1, 1 },
                    { 6005, 1, 6, "no-image.jpg", "Kolonia Town", 1, 1 },
                    { 6006, 1, 6, "no-image.jpg", "Nema", 1, 1 },
                    { 6007, 1, 6, "no-image.jpg", "Satowan Village", 1, 1 },
                    { 6008, 1, 6, "no-image.jpg", "Lukunor Village", 1, 1 },
                    { 6009, 1, 6, "no-image.jpg", "Pulap Village", 1, 1 },
                    { 6010, 1, 6, "no-image.jpg", "Kuttu Village", 1, 1 },
                    { 6011, 1, 6, "no-image.jpg", "Moch Village", 1, 1 },
                    { 6012, 1, 6, "no-image.jpg", "Nomwin Village", 1, 1 },
                    { 7001, 1, 7, "no-image.jpg", "Meneng Terrace", 1, 1 },
                    { 7002, 1, 7, "no-image.jpg", "Yaren", 1, 1 },
                    { 7003, 1, 7, "no-image.jpg", "Yangor", 1, 1 },
                    { 7004, 1, 7, "no-image.jpg", "Ronave", 1, 1 },
                    { 8001, 1, 8, "no-image.jpg", "Auckland", 1, 1 },
                    { 8002, 1, 8, "no-image.jpg", "Christchurch", 1, 1 },
                    { 8003, 1, 8, "no-image.jpg", "Dunedin", 1, 1 },
                    { 8004, 1, 8, "no-image.jpg", "Hamilton", 1, 1 },
                    { 8005, 1, 8, "no-image.jpg", "Nelson", 1, 1 },
                    { 8006, 1, 8, "no-image.jpg", "Gisborne", 1, 1 },
                    { 8007, 1, 8, "no-image.jpg", "Palmerston North", 1, 1 },
                    { 8008, 1, 8, "no-image.jpg", "Rotorua", 1, 1 },
                    { 8009, 1, 8, "no-image.jpg", "Tauranga", 1, 1 },
                    { 8010, 1, 8, "no-image.jpg", "Mount Cook", 1, 1 },
                    { 8011, 1, 8, "no-image.jpg", "Matamata", 1, 1 },
                    { 9001, 1, 9, "no-image.jpg", "Port Moresby", 1, 1 },
                    { 9002, 1, 9, "no-image.jpg", "Lae", 1, 1 },
                    { 9003, 1, 9, "no-image.jpg", "Arawa", 1, 1 },
                    { 9004, 1, 9, "no-image.jpg", "Mount Hagen", 1, 1 },
                    { 9005, 1, 9, "no-image.jpg", "Popondetta", 1, 1 },
                    { 9006, 1, 9, "no-image.jpg", "Alotau", 1, 1 },
                    { 9007, 1, 9, "no-image.jpg", "Madang", 1, 1 },
                    { 10001, 1, 10, "no-image.jpg", "Apia", 1, 1 },
                    { 10002, 1, 10, "no-image.jpg", "Mount Fito", 1, 1 },
                    { 10003, 1, 10, "no-image.jpg", "Samatau", 1, 1 },
                    { 10004, 1, 10, "no-image.jpg", "Mount Silisili", 1, 1 },
                    { 10005, 1, 10, "no-image.jpg", "Mount Vaea", 1, 1 },
                    { 11001, 1, 11, "no-image.jpg", "Honiara", 1, 1 },
                    { 11002, 1, 11, "no-image.jpg", "Auki", 1, 1 },
                    { 11003, 1, 11, "no-image.jpg", "Gizo", 1, 1 },
                    { 11004, 1, 11, "no-image.jpg", "Guadalcanal", 1, 1 },
                    { 11005, 1, 11, "no-image.jpg", "Rennell Island", 1, 1 },
                    { 12001, 1, 12, "no-image.jpg", "Nuku'alofa", 1, 1 },
                    { 12002, 1, 12, "no-image.jpg", "Neiafu", 1, 1 },
                    { 12003, 1, 12, "no-image.jpg", "Pangai", 1, 1 },
                    { 13001, 1, 13, "no-image.jpg", "Lakatoro", 1, 1 },
                    { 13002, 1, 13, "no-image.jpg", "Port Vila", 1, 1 },
                    { 13003, 1, 13, "no-image.jpg", "Mount Yasur", 1, 1 },
                    { 13004, 1, 13, "no-image.jpg", "Blue Lagoon", 1, 1 },
                    { 13005, 1, 13, "no-image.jpg", "Mystery Island", 1, 1 },
                    { 13006, 1, 13, "no-image.jpg", "Mele Cascades", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tripstop",
                columns: new[] { "Id", "DestinationID", "Enddate", "Startdate", "TripID" },
                values: new object[,]
                {
                    { 1, 1001, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 2, 1002, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 3, 1003, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 2 },
                    { 4, 1004, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 2 }
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
