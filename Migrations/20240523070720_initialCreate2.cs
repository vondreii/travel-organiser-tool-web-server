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
            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "ClimateTypeID", "CountryID", "ImageFilename", "Name", "PopulationTypeID", "TerrainTypeID" },
                values: new object[,]
                {
                    { 14001, 1, 14, "no-image.jpg", "Bandar Seri Begawan", 1, 1 },
                    { 14002, 1, 14, "no-image.jpg", "Kampung Ayer", 1, 1 },
                    { 14003, 1, 14, "no-image.jpg", "Omar Ali Saifuddien Mosque", 1, 1 },
                    { 14004, 1, 14, "no-image.jpg", "Jame' Asr Hassanil Bolkiah Mosque", 1, 1 },
                    { 14005, 1, 14, "no-image.jpg", "Istana Nurul Iman", 1, 1 },
                    { 14006, 1, 14, "no-image.jpg", "Billionth Barrel Monument", 1, 1 },
                    { 15001, 1, 15, "no-image.jpg", "Yangon", 1, 1 },
                    { 15002, 1, 15, "no-image.jpg", "Mandalay", 1, 1 },
                    { 15003, 1, 15, "no-image.jpg", "Naypyitaw", 1, 1 },
                    { 16001, 1, 16, "no-image.jpg", "Krong Battambang", 1, 1 },
                    { 16002, 1, 16, "no-image.jpg", "Phnom Penh", 1, 1 },
                    { 16003, 1, 16, "no-image.jpg", "Krong Siem Reap", 1, 1 },
                    { 16004, 1, 16, "no-image.jpg", "Angkor Wat", 1, 1 },
                    { 16005, 1, 16, "no-image.jpg", "Choeung Ek", 1, 1 },
                    { 17001, 1, 17, "no-image.jpg", "Dili", 1, 1 },
                    { 17002, 1, 17, "no-image.jpg", "Ainaro", 1, 1 },
                    { 17003, 1, 17, "no-image.jpg", "Cristo Rei of Dili", 1, 1 },
                    { 17004, 1, 17, "no-image.jpg", "Church of Saint Anthony of Motael", 1, 1 },
                    { 18001, 1, 18, "no-image.jpg", "Jakarta", 1, 1 },
                    { 18002, 1, 18, "no-image.jpg", "Medan", 1, 1 },
                    { 18003, 1, 18, "no-image.jpg", "Padang", 1, 1 },
                    { 18004, 1, 18, "no-image.jpg", "Surabaya", 1, 1 },
                    { 18005, 1, 18, "no-image.jpg", "Makassar", 1, 1 },
                    { 18006, 1, 18, "no-image.jpg", "Sacred Monkey Forest Sanctuary", 1, 1 },
                    { 19001, 1, 19, "no-image.jpg", "Vientiane", 1, 1 },
                    { 19002, 1, 19, "no-image.jpg", "Luang Prabang", 1, 1 },
                    { 19003, 1, 19, "no-image.jpg", "Pha That Luang Vientiane", 1, 1 },
                    { 19004, 1, 19, "no-image.jpg", "Patuxay - Victory Monument", 1, 1 },
                    { 20001, 1, 20, "no-image.jpg", "Federal Territory of Kuala Lumpur", 1, 1 },
                    { 20002, 1, 20, "no-image.jpg", "George Town", 1, 1 },
                    { 20003, 1, 20, "no-image.jpg", "Malacca", 1, 1 },
                    { 20004, 1, 20, "no-image.jpg", "Batu Caves", 1, 1 },
                    { 22001, 1, 22, "no-image.jpg", "Manila", 1, 1 },
                    { 22002, 1, 22, "no-image.jpg", "Quezon City", 1, 1 },
                    { 22003, 1, 22, "no-image.jpg", "Pasay", 1, 1 },
                    { 22004, 1, 22, "no-image.jpg", "Cavite City", 1, 1 },
                    { 22005, 1, 22, "no-image.jpg", "Baguio", 1, 1 },
                    { 22006, 1, 22, "no-image.jpg", "Caloocan", 1, 1 },
                    { 22007, 1, 22, "no-image.jpg", "Vigan City", 1, 1 },
                    { 22008, 1, 22, "no-image.jpg", "Tagaytay", 1, 1 },
                    { 22009, 1, 22, "no-image.jpg", "Makati", 1, 1 },
                    { 22010, 1, 22, "no-image.jpg", "Angeles City", 1, 1 },
                    { 23001, 1, 23, "no-image.jpg", "Singapore", 1, 1 },
                    { 23002, 1, 23, "no-image.jpg", "Marina Bay", 1, 1 },
                    { 23003, 1, 23, "no-image.jpg", "Gardens by the Bay", 1, 1 },
                    { 23004, 1, 23, "no-image.jpg", "Merlion Park waterfront", 1, 1 },
                    { 24001, 1, 24, "no-image.jpg", "The Grand Palace", 1, 1 },
                    { 24002, 1, 24, "no-image.jpg", "Bangkok", 1, 1 },
                    { 24003, 1, 24, "no-image.jpg", "Chiang Mai", 1, 1 },
                    { 24004, 1, 24, "no-image.jpg", "Pattaya City", 1, 1 },
                    { 24005, 1, 24, "no-image.jpg", "Doi Inthanon", 1, 1 },
                    { 24006, 1, 24, "no-image.jpg", "Khao Yai National Park", 1, 1 },
                    { 25001, 1, 25, "no-image.jpg", "Ho Chi Minh City", 1, 1 },
                    { 25002, 1, 25, "no-image.jpg", "Hanoi", 1, 1 },
                    { 25003, 1, 25, "no-image.jpg", "Da Nang", 1, 1 },
                    { 25004, 1, 25, "no-image.jpg", "Can Tho", 1, 1 },
                    { 25005, 1, 25, "no-image.jpg", "Cu Chi Tunnel", 1, 1 },
                    { 25006, 1, 25, "no-image.jpg", "Ho Chi Minh's Mausoleum", 1, 1 },
                    { 26001, 1, 26, "no-image.jpg", "Beijing", 1, 1 },
                    { 26002, 1, 26, "no-image.jpg", "Chongqing", 1, 1 },
                    { 26003, 1, 26, "no-image.jpg", "Shanghai", 1, 1 },
                    { 26004, 1, 26, "no-image.jpg", "Mudanjiang", 1, 1 },
                    { 26005, 1, 26, "no-image.jpg", "Guangzhou", 1, 1 },
                    { 26006, 1, 26, "no-image.jpg", "Chengdu", 1, 1 },
                    { 26007, 1, 26, "no-image.jpg", "Nanjing", 1, 1 },
                    { 26008, 1, 26, "no-image.jpg", "Xi’an", 1, 1 },
                    { 26009, 1, 26, "no-image.jpg", "Changsha", 1, 1 },
                    { 26010, 1, 26, "no-image.jpg", "Great Wall of China", 1, 1 },
                    { 26011, 1, 26, "no-image.jpg", "Emperor Qinshihuang's Mausoleum Site", 1, 1 },
                    { 27001, 1, 27, "no-image.jpg", "Tokyo", 1, 1 },
                    { 27002, 1, 27, "no-image.jpg", "Kyoto", 1, 1 },
                    { 27003, 1, 27, "no-image.jpg", "Sapporo", 1, 1 },
                    { 27004, 1, 27, "no-image.jpg", "Osaka", 1, 1 },
                    { 27005, 1, 27, "no-image.jpg", "Yokohama", 1, 1 },
                    { 27006, 1, 27, "no-image.jpg", "Nagoya", 1, 1 },
                    { 27007, 1, 27, "no-image.jpg", "Kobe", 1, 1 },
                    { 27008, 1, 27, "no-image.jpg", "Hiroshima", 1, 1 },
                    { 27009, 1, 27, "no-image.jpg", "Fukuoka", 1, 1 },
                    { 27010, 1, 27, "no-image.jpg", "Mount Fuji", 1, 1 },
                    { 28001, 1, 28, "no-image.jpg", "Ulaanbaatar", 1, 1 },
                    { 28002, 1, 28, "no-image.jpg", "Choibalsan", 1, 1 },
                    { 28003, 1, 28, "no-image.jpg", "Erdenet", 1, 1 },
                    { 28004, 1, 28, "no-image.jpg", "Genghis Khan Statue", 1, 1 },
                    { 28005, 1, 28, "no-image.jpg", "Amarbayasgalant Monastery", 1, 1 },
                    { 29001, 1, 29, "no-image.jpg", "Seoul", 1, 1 },
                    { 29002, 1, 29, "no-image.jpg", "Busan", 1, 1 },
                    { 29003, 1, 29, "no-image.jpg", "Incheon", 1, 1 },
                    { 29004, 1, 29, "no-image.jpg", "Daejeon", 1, 1 },
                    { 29005, 1, 29, "no-image.jpg", "Gwangju", 1, 1 },
                    { 29006, 1, 29, "no-image.jpg", "Gyeongbokgung Palace", 1, 1 },
                    { 30001, 1, 30, "no-image.jpg", "Pyongyang", 1, 1 },
                    { 31001, 1, 31, "no-image.jpg", "National Palace Museum", 1, 1 },
                    { 31002, 1, 31, "no-image.jpg", "Taipei", 1, 1 },
                    { 31003, 1, 31, "no-image.jpg", "Taichung", 1, 1 },
                    { 31004, 1, 31, "no-image.jpg", "Yushan", 1, 1 },
                    { 31005, 1, 31, "no-image.jpg", "Lungshan Temple", 1, 1 },
                    { 31006, 1, 31, "no-image.jpg", "Fo Guang Shan Buddha Museum", 1, 1 },
                    { 32001, 1, 32, "no-image.jpg", "Ruins of St. Paul's", 1, 1 },
                    { 33001, 1, 33, "no-image.jpg", "Hong Kong Disneyland", 1, 1 },
                    { 33002, 1, 33, "no-image.jpg", "Tian Tan Buddha", 1, 1 },
                    { 33003, 1, 33, "no-image.jpg", "Lantau Island", 1, 1 },
                    { 33004, 1, 33, "no-image.jpg", "Ocean Park", 1, 1 },
                    { 34001, 1, 34, "no-image.jpg", "Kabul", 1, 1 },
                    { 34002, 1, 34, "no-image.jpg", "Herat", 1, 1 },
                    { 34003, 1, 34, "no-image.jpg", "Kandahar", 1, 1 },
                    { 34004, 1, 34, "no-image.jpg", "Buddha of Bamyan", 1, 1 },
                    { 34005, 1, 34, "no-image.jpg", "Darul Aman Palace", 1, 1 },
                    { 34006, 1, 34, "no-image.jpg", "Babur Tomb", 1, 1 },
                    { 35001, 1, 35, "no-image.jpg", "Dhaka", 1, 1 },
                    { 35002, 1, 35, "no-image.jpg", "Khulna", 1, 1 },
                    { 35003, 1, 35, "no-image.jpg", "Mymensingh", 1, 1 },
                    { 35004, 1, 35, "no-image.jpg", "Sylhet", 1, 1 },
                    { 35005, 1, 35, "no-image.jpg", "Chittagong", 1, 1 },
                    { 35006, 1, 35, "no-image.jpg", "Lalbagh Fort", 1, 1 },
                    { 36001, 1, 36, "no-image.jpg", "Thimphu", 1, 1 },
                    { 36002, 1, 36, "no-image.jpg", "Paro", 1, 1 },
                    { 36003, 1, 36, "no-image.jpg", "Punakha", 1, 1 },
                    { 36004, 1, 36, "no-image.jpg", "Wangdue Phodrang", 1, 1 },
                    { 36005, 1, 36, "no-image.jpg", "Jakar", 1, 1 },
                    { 36006, 1, 36, "no-image.jpg", "National Memorial Chhorten", 1, 1 },
                    { 37001, 1, 37, "no-image.jpg", "Mumbai", 1, 1 },
                    { 37002, 1, 37, "no-image.jpg", "Kolkata", 1, 1 },
                    { 37003, 1, 37, "no-image.jpg", "Chennai", 1, 1 },
                    { 37004, 1, 37, "no-image.jpg", "Hyderabad", 1, 1 },
                    { 37005, 1, 37, "no-image.jpg", "New Delhi", 1, 1 },
                    { 37006, 1, 37, "no-image.jpg", "Taj Mahal", 1, 1 },
                    { 37007, 1, 37, "no-image.jpg", "Meenakshi Amman Temple", 1, 1 },
                    { 38001, 1, 38, "no-image.jpg", "Kathmandu", 1, 1 },
                    { 38002, 1, 38, "no-image.jpg", "Pokhara", 1, 1 },
                    { 38003, 1, 38, "no-image.jpg", "Janakpurdham", 1, 1 },
                    { 38004, 1, 38, "no-image.jpg", "Pashupatinath Temple", 1, 1 },
                    { 38005, 1, 38, "no-image.jpg", "Mount Everest", 1, 1 },
                    { 38006, 1, 38, "no-image.jpg", "Manaslu", 1, 1 },
                    { 39001, 1, 39, "no-image.jpg", "Male", 1, 1 },
                    { 39002, 1, 39, "no-image.jpg", "Addu City", 1, 1 },
                    { 39003, 1, 39, "no-image.jpg", "Republic Square", 1, 1 },
                    { 39004, 1, 39, "no-image.jpg", "Tsunami Monument", 1, 1 },
                    { 39005, 1, 39, "no-image.jpg", "Veligandu Maldives Resort Island", 1, 1 },
                    { 40001, 1, 40, "no-image.jpg", "K2", 1, 1 },
                    { 40002, 1, 40, "no-image.jpg", "Kamalia", 1, 1 },
                    { 40003, 1, 40, "no-image.jpg", "Hafizabad", 1, 1 },
                    { 40004, 1, 40, "no-image.jpg", "Badshahi Mosque", 1, 1 },
                    { 41001, 1, 41, "no-image.jpg", "Colombo", 1, 1 },
                    { 41002, 1, 41, "no-image.jpg", "Kandy", 1, 1 },
                    { 41003, 1, 41, "no-image.jpg", "Sigiriya", 1, 1 },
                    { 41004, 1, 41, "no-image.jpg", "Sri Dalada Maligawa", 1, 1 },
                    { 41005, 1, 41, "no-image.jpg", "Galle Dutch Fort", 1, 1 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 14001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 14002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 14003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 14004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 14005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 14006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 15001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 15002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 15003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 16001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 16002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 16003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 16004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 16005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 17001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 17002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 17003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 17004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 18001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 18002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 18003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 18004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 18005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 18006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 19001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 19002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 19003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 19004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 20001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 20002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 20003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 20004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 22001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 22002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 22003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 22004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 22005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 22006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 22007);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 22008);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 22009);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 22010);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 23001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 23002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 23003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 23004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 24001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 24002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 24003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 24004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 24005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 24006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 25001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 25002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 25003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 25004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 25005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 25006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 26001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 26002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 26003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 26004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 26005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 26006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 26007);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 26008);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 26009);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 26010);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 26011);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 27001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 27002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 27003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 27004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 27005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 27006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 27007);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 27008);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 27009);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 27010);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 28001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 28002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 28003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 28004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 28005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 29001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 29002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 29003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 29004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 29005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 29006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 30001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 31001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 31002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 31003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 31004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 31005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 31006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 32001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 33001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 33002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 33003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 33004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 34001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 34002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 34003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 34004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 34005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 34006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 35001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 35002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 35003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 35004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 35005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 35006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 36001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 36002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 36003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 36004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 36005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 36006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 37001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 37002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 37003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 37004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 37005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 37006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 37007);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 38001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 38002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 38003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 38004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 38005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 38006);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 39001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 39002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 39003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 39004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 39005);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 40001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 40002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 40003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 40004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 41001);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 41002);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 41003);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 41004);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 41005);

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tripstop",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Enddate", "Startdate" },
                values: new object[] { new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
