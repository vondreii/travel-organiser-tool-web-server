using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelOrganiserTool.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "ClimateTypeID", "CountryID", "ImageFilename", "Name", "PopulationTypeID", "TerrainTypeID" },
                values: new object[,]
                {
                    { 84001, 1, 84, "no-image.jpg", "Berat", 1, 1 },
                    { 84002, 1, 84, "no-image.jpg", "Gjirokaster Castle", 1, 1 },
                    { 84003, 1, 84, "no-image.jpg", "Mount Korab", 1, 1 },
                    { 85001, 1, 85, "no-image.jpg", "Andorra la Vella", 1, 1 },
                    { 85002, 1, 85, "no-image.jpg", "El Pas de la Casa", 1, 1 },
                    { 86001, 1, 86, "no-image.jpg", "Sarajevo", 1, 1 },
                    { 86002, 1, 86, "no-image.jpg", "Perucica", 1, 1 },
                    { 87001, 1, 87, "no-image.jpg", "Zagreb", 1, 1 },
                    { 87002, 1, 87, "no-image.jpg", "Zadar", 1, 1 },
                    { 87003, 1, 87, "no-image.jpg", "Motovun", 1, 1 },
                    { 87004, 1, 87, "no-image.jpg", "Split", 1, 1 },
                    { 88001, 1, 88, "no-image.jpg", "Larnaca", 1, 1 },
                    { 88002, 1, 88, "no-image.jpg", "Limassol", 1, 1 },
                    { 88003, 1, 88, "no-image.jpg", "Kiti", 1, 1 },
                    { 89001, 1, 89, "no-image.jpg", "Athens", 1, 1 },
                    { 89002, 1, 89, "no-image.jpg", "Rhodes", 1, 1 },
                    { 89003, 1, 89, "no-image.jpg", "Nafplio", 1, 1 },
                    { 89004, 1, 89, "no-image.jpg", "Chania", 1, 1 },
                    { 89005, 1, 89, "no-image.jpg", "Lake Beletsi", 1, 1 },
                    { 89006, 1, 89, "no-image.jpg", "Mount Olympus", 1, 1 },
                    { 89007, 1, 89, "no-image.jpg", "Balos Lagoon", 1, 1 },
                    { 89008, 1, 89, "no-image.jpg", "Elafonissi Beach", 1, 1 },
                    { 90001, 1, 90, "no-image.jpg", "Rome", 1, 1 },
                    { 90002, 1, 90, "no-image.jpg", "Florence", 1, 1 },
                    { 90003, 1, 90, "no-image.jpg", "Venice", 1, 1 },
                    { 90004, 1, 90, "no-image.jpg", "Naples", 1, 1 },
                    { 90005, 1, 90, "no-image.jpg", "Milan", 1, 1 },
                    { 90006, 1, 90, "no-image.jpg", "Verona", 1, 1 },
                    { 90007, 1, 90, "no-image.jpg", "Colosseum", 1, 1 },
                    { 90008, 1, 90, "no-image.jpg", "Mount Etna", 1, 1 },
                    { 90009, 1, 90, "no-image.jpg", "Lake Garda", 1, 1 },
                    { 90010, 1, 90, "no-image.jpg", "Parco Forlanini", 1, 1 },
                    { 91001, 1, 91, "no-image.jpg", "Prizren", 1, 1 },
                    { 91002, 1, 91, "no-image.jpg", "Prizren Fortress", 1, 1 },
                    { 91003, 1, 91, "no-image.jpg", "Sharr Mountains National Park", 1, 1 },
                    { 92001, 1, 92, "no-image.jpg", "Valletta", 1, 1 },
                    { 92002, 1, 92, "no-image.jpg", "Popeye Village", 1, 1 },
                    { 92003, 1, 92, "no-image.jpg", "St. John's Co-Cathedral", 1, 1 },
                    { 93001, 1, 93, "no-image.jpg", "Monaco City", 1, 1 },
                    { 93002, 1, 93, "no-image.jpg", "Prince's Palace of Monaco", 1, 1 },
                    { 94001, 1, 94, "no-image.jpg", "Podgorica", 1, 1 },
                    { 94002, 1, 94, "no-image.jpg", "Budva", 1, 1 },
                    { 94003, 1, 94, "no-image.jpg", "Ulcinj", 1, 1 },
                    { 95001, 1, 95, "no-image.jpg", "Prilep", 1, 1 },
                    { 95002, 1, 95, "no-image.jpg", "Kriva Palanka", 1, 1 },
                    { 95003, 1, 95, "no-image.jpg", "Stone Bridge", 1, 1 },
                    { 96001, 1, 96, "no-image.jpg", "Lisbon", 1, 1 },
                    { 96002, 1, 96, "no-image.jpg", "Porto", 1, 1 },
                    { 96003, 1, 96, "no-image.jpg", "Torre de Belem", 1, 1 },
                    { 96004, 1, 96, "no-image.jpg", "Ria Formosa Nature Park", 1, 1 },
                    { 97001, 1, 97, "no-image.jpg", "Ljubljana", 1, 1 },
                    { 97002, 1, 97, "no-image.jpg", "Ptuj", 1, 1 },
                    { 97003, 1, 97, "no-image.jpg", "Predjama Castle", 1, 1 },
                    { 97004, 1, 97, "no-image.jpg", "Dragon Bridge", 1, 1 },
                    { 97005, 1, 97, "no-image.jpg", "Bled Castle", 1, 1 },
                    { 98001, 1, 98, "no-image.jpg", "Barcelona", 1, 1 },
                    { 98002, 1, 98, "no-image.jpg", "Seville", 1, 1 },
                    { 98003, 1, 98, "no-image.jpg", "Madrid", 1, 1 },
                    { 98004, 1, 98, "no-image.jpg", "Valencia", 1, 1 },
                    { 98005, 1, 98, "no-image.jpg", "Bilbao", 1, 1 },
                    { 98006, 1, 98, "no-image.jpg", "The Alhambra", 1, 1 },
                    { 98007, 1, 98, "no-image.jpg", "Granada", 1, 1 },
                    { 99001, 1, 99, "no-image.jpg", "Yerevan", 1, 1 },
                    { 100001, 1, 100, "no-image.jpg", "Baku", 1, 1 },
                    { 100002, 1, 100, "no-image.jpg", "Palace of the Shirvanshahs", 1, 1 },
                    { 101001, 1, 101, "no-image.jpg", "Minsk", 1, 1 },
                    { 101002, 1, 101, "no-image.jpg", "Grodno", 1, 1 },
                    { 101003, 1, 101, "no-image.jpg", "Losyсki Park", 1, 1 },
                    { 102001, 1, 102, "no-image.jpg", "Tallinn", 1, 1 },
                    { 102002, 1, 102, "no-image.jpg", "Narva", 1, 1 },
                    { 102003, 1, 102, "no-image.jpg", "Rakvere", 1, 1 },
                    { 102004, 1, 102, "no-image.jpg", "Viru Gate", 1, 1 },
                    { 103001, 1, 103, "no-image.jpg", "Tbilisi", 1, 1 },
                    { 103002, 1, 103, "no-image.jpg", "Kutaisi", 1, 1 },
                    { 103003, 1, 103, "no-image.jpg", "Batumi", 1, 1 },
                    { 103004, 1, 103, "no-image.jpg", "Gergeti Trinity Church", 1, 1 },
                    { 104001, 1, 104, "no-image.jpg", "Astana", 1, 1 },
                    { 104002, 1, 104, "no-image.jpg", "Almaty", 1, 1 },
                    { 104003, 1, 104, "no-image.jpg", "Aktobe", 1, 1 },
                    { 105001, 1, 105, "no-image.jpg", "Bishkek", 1, 1 },
                    { 106001, 1, 106, "no-image.jpg", "Riga", 1, 1 },
                    { 106002, 1, 106, "no-image.jpg", "Jurmala", 1, 1 },
                    { 106003, 1, 106, "no-image.jpg", "Jelgava", 1, 1 },
                    { 106004, 1, 106, "no-image.jpg", "Dobele", 1, 1 },
                    { 107001, 1, 107, "no-image.jpg", "Vilnius", 1, 1 },
                    { 107002, 1, 107, "no-image.jpg", "Kaunas", 1, 1 },
                    { 107003, 1, 107, "no-image.jpg", "Klaipeda", 1, 1 },
                    { 107004, 1, 107, "no-image.jpg", "Trakai Island Castle", 1, 1 },
                    { 107005, 1, 107, "no-image.jpg", "Hill of Crosses", 1, 1 },
                    { 108001, 1, 108, "no-image.jpg", "Soroca", 1, 1 },
                    { 108002, 1, 108, "no-image.jpg", "Orhei", 1, 1 },
                    { 108003, 1, 108, "no-image.jpg", "Curchi Monastery", 1, 1 },
                    { 108004, 1, 108, "no-image.jpg", "Codru", 1, 1 },
                    { 109001, 1, 109, "no-image.jpg", "Moscow", 1, 1 },
                    { 109002, 1, 109, "no-image.jpg", "Saint Petersburg", 1, 1 },
                    { 109003, 1, 109, "no-image.jpg", "Kazan", 1, 1 },
                    { 109004, 1, 109, "no-image.jpg", "Red Square", 1, 1 },
                    { 109005, 1, 109, "no-image.jpg", "Lake Baikal", 1, 1 },
                    { 109006, 1, 109, "no-image.jpg", "Altai Mountains", 1, 1 },
                    { 109007, 1, 109, "no-image.jpg", "Mount Elbrus", 1, 1 },
                    { 109008, 1, 109, "no-image.jpg", "Kungur Ice Cave", 1, 1 },
                    { 110001, 1, 110, "no-image.jpg", "Khujand", 1, 1 },
                    { 110002, 1, 110, "no-image.jpg", "Dushanbe", 1, 1 },
                    { 111001, 1, 111, "no-image.jpg", "Ashgabat", 1, 1 },
                    { 112001, 1, 112, "no-image.jpg", "Donetsk", 1, 1 },
                    { 112002, 1, 112, "no-image.jpg", "Lviv", 1, 1 },
                    { 112003, 1, 112, "no-image.jpg", "Kyiv", 1, 1 },
                    { 112004, 1, 112, "no-image.jpg", "Dniester Canyon", 1, 1 },
                    { 112005, 1, 112, "no-image.jpg", "Oleshky Sands", 1, 1 },
                    { 113001, 1, 113, "no-image.jpg", "Tashkent", 1, 1 },
                    { 113002, 1, 113, "no-image.jpg", "Samarkand", 1, 1 },
                    { 113003, 1, 113, "no-image.jpg", "Registan Square", 1, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 84001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 84002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 84003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 85001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 85002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 86001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 86002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 87001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 87002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 87003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 87004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 88001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 88002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 88003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 89001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 89002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 89003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 89004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 89005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 89006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 89007);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 89008);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 90001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 90002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 90003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 90004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 90005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 90006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 90007);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 90008);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 90009);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 90010);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 91001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 91002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 91003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 92001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 92002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 92003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 93001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 93002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 94001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 94002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 94003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 95001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 95002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 95003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 96001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 96002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 96003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 96004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 97001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 97002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 97003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 97004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 97005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 98001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 98002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 98003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 98004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 98005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 98006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 98007);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 99001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 100001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 100002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 101001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 101002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 101003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 102001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 102002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 102003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 102004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 103001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 103002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 103003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 103004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 104001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 104002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 104003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 105001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 106001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 106002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 106003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 106004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 107001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 107002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 107003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 107004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 107005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 108001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 108002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 108003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 108004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 109001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 109002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 109003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 109004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 109005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 109006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 109007);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 109008);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 110001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 110002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 111001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 112001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 112002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 112003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 112004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 112005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 113001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 113002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 113003);
        }
    }
}
