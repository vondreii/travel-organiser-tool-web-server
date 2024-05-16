using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Cook Islands");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Fiji");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Kiribati");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Marshall Islands");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Micronesia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Nauru");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "New Zealand");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Papua New Guinea");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "RegionID" },
                values: new object[] { "Samoa", 1 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "RegionID" },
                values: new object[] { "Solomon Islands", 1 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "RegionID" },
                values: new object[] { "Tonga", 1 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "RegionID" },
                values: new object[] { "Vanuatu", 1 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Brunei");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Burma");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageFilename", "Name" },
                values: new object[] { "no-image.jpg", "Cambodia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageFilename", "Name" },
                values: new object[] { "no-image.jpg", "Timor-Leste" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageFilename", "Name" },
                values: new object[] { "no-image.jpg", "Indonesia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImageFilename", "Name" },
                values: new object[] { "no-image.jpg", "Laos" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImageFilename", "Name" },
                values: new object[] { "malaysia.jpg", "Malaysia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImageFilename", "Name", "RegionID" },
                values: new object[] { "no-image.jpg", "Myanmar", 2 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImageFilename", "Name", "RegionID" },
                values: new object[] { "philippines.jpg", "Philippines", 2 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImageFilename", "Name", "RegionID" },
                values: new object[] { "singapore.jpg", "Singapore", 2 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImageFilename", "Name", "RegionID" },
                values: new object[] { "thailand.jpg", "Thailand", 2 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImageFilename", "Name", "RegionID" },
                values: new object[] { "vietnam.jpg", "Vietnam", 2 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ImageFilename", "Name" },
                values: new object[] { "china.jpg", "China" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ImageFilename", "Name" },
                values: new object[] { "japan.jpg", "Japan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Mongolia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ImageFilename", "Name", "RegionID" },
                values: new object[] { "south-korea.jpg", "South Korea", 3 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "RegionID" },
                values: new object[] { "North Korea", 3 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "RegionID" },
                values: new object[] { "Taiwan", 3 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ImageFilename", "Name", "RegionID" },
                values: new object[] { "no-image.jpg", "Macao", 3 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "RegionID" },
                values: new object[] { "Hong Kong", 3 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Afghanistan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Bangladesh");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "Bhutan");

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "ImageFilename", "Name", "RegionID" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "United Kingdom and Western Europe");

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Central Europe");

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "South Pole");

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "Id", "Name" },
                values: new object[] { 17, "Eastern Europe and Former USSR" });

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "ImageFilename", "Name", "RegionID" },
                values: new object[,]
                {
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
                    { 113, "no-image.jpg", "Uzbekistan", 17 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "New Zealand");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Solomon Islands");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Cook Islands");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Papua New Guinea");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Fiji");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Micronesia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Samoa");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Vanuatu");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "RegionID" },
                values: new object[] { "Brunei", 2 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "RegionID" },
                values: new object[] { "Burma", 2 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "RegionID" },
                values: new object[] { "Cambodia", 2 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "RegionID" },
                values: new object[] { "Timor-Leste", 2 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Indonesia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Laos");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageFilename", "Name" },
                values: new object[] { "malaysia.jpg", "Malaysia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageFilename", "Name" },
                values: new object[] { "philippines.jpg", "Philippines" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageFilename", "Name" },
                values: new object[] { "singapore.jpg", "Singapore" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImageFilename", "Name" },
                values: new object[] { "thailand.jpg", "Thailand" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImageFilename", "Name" },
                values: new object[] { "vietnam.jpg", "Vietnam" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImageFilename", "Name", "RegionID" },
                values: new object[] { "china.jpg", "China", 3 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImageFilename", "Name", "RegionID" },
                values: new object[] { "japan.jpg", "Japan", 3 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImageFilename", "Name", "RegionID" },
                values: new object[] { "no-image.jpg", "Mongolia", 3 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImageFilename", "Name", "RegionID" },
                values: new object[] { "south-korea.jpg", "South Korea", 3 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImageFilename", "Name", "RegionID" },
                values: new object[] { "no-image.jpg", "North Korea", 3 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ImageFilename", "Name" },
                values: new object[] { "no-image.jpg", "Taiwan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ImageFilename", "Name" },
                values: new object[] { "no-image.jpg", "Macao" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Hong Kong");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ImageFilename", "Name", "RegionID" },
                values: new object[] { "no-image.jpg", "Afghanistan", 4 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "RegionID" },
                values: new object[] { "Bangladesh", 4 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "RegionID" },
                values: new object[] { "Bhutan", 4 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ImageFilename", "Name", "RegionID" },
                values: new object[] { "india.jpg", "India", 4 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "RegionID" },
                values: new object[] { "Nepal", 4 });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Maldives");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Pakistan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "Sri Lanka");

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "United Kingdom");

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Western Europe");

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Polar Regions");

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
