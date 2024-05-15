using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Data
{
    public static class CountryDbData
    {
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                // Oceania
                new Country { Id = 1, RegionID = 1, Name = "Australia", ImageFilename = "australia.jpg" },
                new Country { Id = 2, RegionID = 1, Name = "New Zealand", ImageFilename = "no-image.jpg" },
                new Country { Id = 3, RegionID = 1, Name = "Solomon Islands", ImageFilename = "no-image.jpg" },
                new Country { Id = 4, RegionID = 1, Name = "Cook Islands", ImageFilename = "no-image.jpg" },
                new Country { Id = 5, RegionID = 1, Name = "Papua New Guinea", ImageFilename = "no-image.jpg" },
                new Country { Id = 6, RegionID = 1, Name = "Fiji", ImageFilename = "no-image.jpg" },
                new Country { Id = 7, RegionID = 1, Name = "Micronesia", ImageFilename = "no-image.jpg" },
                new Country { Id = 8, RegionID = 1, Name = "Samoa", ImageFilename = "no-image.jpg" },
                new Country { Id = 9, RegionID = 1, Name = "Vanuatu", ImageFilename = "no-image.jpg" },

                // South East Asia
                new Country { Id = 10, RegionID = 2, Name = "Brunei", ImageFilename = "no-image.jpg" },
                new Country { Id = 11, RegionID = 2, Name = "Burma", ImageFilename = "no-image.jpg" },
                new Country { Id = 12, RegionID = 2, Name = "Cambodia", ImageFilename = "no-image.jpg" },
                new Country { Id = 13, RegionID = 2, Name = "Timor-Leste", ImageFilename = "no-image.jpg" },
                new Country { Id = 14, RegionID = 2, Name = "Indonesia", ImageFilename = "no-image.jpg" },
                new Country { Id = 15, RegionID = 2, Name = "Laos", ImageFilename = "no-image.jpg" },
                new Country { Id = 16, RegionID = 2, Name = "Malaysia", ImageFilename = "malaysia.jpg" },
                new Country { Id = 17, RegionID = 2, Name = "Philippines", ImageFilename = "philippines.jpg" },
                new Country { Id = 18, RegionID = 2, Name = "Singapore", ImageFilename = "singapore.jpg" },
                new Country { Id = 19, RegionID = 2, Name = "Thailand", ImageFilename = "thailand.jpg" },
                new Country { Id = 20, RegionID = 2, Name = "Vietnam", ImageFilename = "vietnam.jpg" },

                // East Asia
                new Country { Id = 21, RegionID = 3, Name = "China", ImageFilename = "china.jpg" },
                new Country { Id = 22, RegionID = 3, Name = "Japan", ImageFilename = "japan.jpg" },
                new Country { Id = 23, RegionID = 3, Name = "Mongolia", ImageFilename = "no-image.jpg" },
                new Country { Id = 24, RegionID = 3, Name = "South Korea", ImageFilename = "south-korea.jpg" },
                new Country { Id = 25, RegionID = 3, Name = "North Korea", ImageFilename = "no-image.jpg" },
                new Country { Id = 26, RegionID = 3, Name = "Taiwan", ImageFilename = "no-image.jpg" },
                new Country { Id = 27, RegionID = 3, Name = "Macao", ImageFilename = "no-image.jpg" },
                new Country { Id = 28, RegionID = 3, Name = "Hong Kong", ImageFilename = "no-image.jpg" },

                // South Asia
                new Country { Id = 29, RegionID = 4, Name = "Afghanistan", ImageFilename = "no-image.jpg" },
                new Country { Id = 30, RegionID = 4, Name = "Bangladesh", ImageFilename = "no-image.jpg" },
                new Country { Id = 31, RegionID = 4, Name = "Bhutan", ImageFilename = "no-image.jpg" },
                new Country { Id = 32, RegionID = 4, Name = "India", ImageFilename = "india.jpg" },
                new Country { Id = 33, RegionID = 4, Name = "Nepal", ImageFilename = "no-image.jpg" },
                new Country { Id = 34, RegionID = 4, Name = "Maldives", ImageFilename = "no-image.jpg" },
                new Country { Id = 35, RegionID = 4, Name = "Pakistan", ImageFilename = "no-image.jpg" },
                new Country { Id = 36, RegionID = 4, Name = "Sri Lanka", ImageFilename = "no-image.jpg" }

                // Maybe you have to manually fix the db locally. 
                // And just update the Region IDs on Azure.

                // // South East Asia
                // new Country { Id = 3, Name = "India", RegionID = 1, ImageFilename = "india.jpg" },
                // new Country { Id = 4, Name = "Japan", RegionID = 1, ImageFilename = "japan.jpg" },
                // new Country { Id = 5, Name = "Malaysia", RegionID = 1, ImageFilename = "malaysia.jpg" },
                // new Country { Id = 6, Name = "Philippines", RegionID = 1, ImageFilename = "philippines.jpg" },
                // new Country { Id = 7, Name = "Singapore", RegionID = 1, ImageFilename = "singapore.jpg" },
                // new Country { Id = 8, Name = "South Korea", RegionID = 1, ImageFilename = "south-korea.jpg" },
                // new Country { Id = 9, Name = "Thailand", RegionID = 1, ImageFilename = "thailand.jpg" },
                // new Country { Id = 10, Name = "Vietnam", RegionID = 1, ImageFilename = "vietnam.jpg" },
                // new Country { Id = 37, Name = "Indonesia", RegionID = 1, ImageFilename = "no-image.jpg" },
                // // East Asia
                // new Country { Id = 2, Name = "China", RegionID = 1, ImageFilename = "china.jpg" },
                // // Central Europe
                // new Country { Id = 11, Name = "Belgium", RegionID = 1, ImageFilename = "no-image.jpg" },
                // new Country { Id = 12, Name = "Denmark", RegionID = 1, ImageFilename = "denmark.jpg" },
                // new Country { Id = 13, Name = "Finland", RegionID = 1, ImageFilename = "finland.jpg" },
                // new Country { Id = 14, Name = "France", RegionID = 1, ImageFilename = "france.jpg" },
                // new Country { Id = 15, Name = "Germany", RegionID = 1, ImageFilename = "germany.jpg" },
                // new Country { Id = 16, Name = "Ireland", RegionID = 1, ImageFilename = "ireland.jpg" },
                // new Country { Id = 17, Name = "Italy", RegionID = 1, ImageFilename = "italy.jpg" },
                // new Country { Id = 18, Name = "Norway", RegionID = 1, ImageFilename = "norway.jpg" },
                // new Country { Id = 19, Name = "United Kingdom", RegionID = 1, ImageFilename = "united-kingdom.jpg" },
                // new Country { Id = 38, Name = "Greece", RegionID = 1, ImageFilename = "no-image.jpg" },
                // // North America
                // new Country { Id = 20, Name = "Bahamas", RegionID = 1, ImageFilename = "no-image.jpg" },
                // new Country { Id = 21, Name = "Canada", RegionID = 1, ImageFilename = "canada.jpg" },
                // new Country { Id = 22, Name = "Jamaica", RegionID = 1, ImageFilename = "jamaica.jpg" },
                // new Country { Id = 23, Name = "Mexico", RegionID = 1, ImageFilename = "mexico.jpg" },
                // new Country { Id = 24, Name = "United States", RegionID = 1, ImageFilename = "united-states.jpg" },
                // new Country { Id = 39, Name = "Cuba", RegionID = 1, ImageFilename = "no-image.jpg" },
                // new Country { Id = 40, Name = "Haiti", RegionID = 1, ImageFilename = "no-image.jpg" },
                // new Country { Id = 41, Name = "Panama", RegionID = 1, ImageFilename = "no-image.jpg" },
                // new Country { Id = 42, Name = "Costa Rica", RegionID = 1, ImageFilename = "no-image.jpg" },
                // new Country { Id = 43, Name = "Barbados", RegionID = 1, ImageFilename = "no-image.jpg" },
                // // South America
                // new Country { Id = 25, Name = "Argentina", RegionID = 1, ImageFilename = "no-image.jpg" },
                // new Country { Id = 26, Name = "Brazil", RegionID = 1, ImageFilename = "brazil.jpg" },
                // new Country { Id = 27, Name = "Chile", RegionID = 1, ImageFilename = "chile.jpg" },
                // new Country { Id = 28, Name = "Ecuador", RegionID = 1, ImageFilename = "ecuador.jpg" },
                // new Country { Id = 29, Name = "Peru", RegionID = 1, ImageFilename = "peru.jpg" },
                // new Country { Id = 44, Name = "Colombia", RegionID = 1, ImageFilename = "no-image.jpg" },
                // new Country { Id = 45, Name = "Venezuela", RegionID = 1, ImageFilename = "no-image.jpg" },
                // new Country { Id = 46, Name = "Guyana", RegionID = 1, ImageFilename = "no-image.jpg" },
                // new Country { Id = 47, Name = "Uruguay", RegionID = 1, ImageFilename = "no-image.jpg" },
                // new Country { Id = 48, Name = "Aruba", RegionID = 1, ImageFilename = "no-image.jpg" },
                // // Northern Africa
                // new Country { Id = 30, Name = "Ethiopia", RegionID = 1, ImageFilename = "ethiopia.jpg" },
                // new Country { Id = 31, Name = "Kenya", RegionID = 1, ImageFilename = "kenya.jpg" },
                // new Country { Id = 32, Name = "Nigeria", RegionID = 1, ImageFilename = "nigeria.jpg" },
                // new Country { Id = 33, Name = "Rwanda", RegionID = 1, ImageFilename = "rwanda.jpg" },
                // new Country { Id = 34, Name = "South Africa", RegionID = 1, ImageFilename = "south-africa.jpg" },
                // new Country { Id = 35, Name = "Zimbabwe", RegionID = 1, ImageFilename = "zimbabwe.jpg" },
                // new Country { Id = 49, Name = "Madagascar", RegionID = 1, ImageFilename = "no-image.jpg" },
                // new Country { Id = 50, Name = "Sudan", RegionID = 1, ImageFilename = "no-image.jpg" },
                // new Country { Id = 51, Name = "South Sudan", RegionID = 1, ImageFilename = "no-image.jpg" },
                // new Country { Id = 52, Name = "Sierra Leone", RegionID = 1, ImageFilename = "no-image.jpg" },
                // // Polar Regions
                // new Country { Id = 36, Name = "Antarctica", RegionID = 1, ImageFilename = "no-image.jpg" }
            );
        }
    }
}
