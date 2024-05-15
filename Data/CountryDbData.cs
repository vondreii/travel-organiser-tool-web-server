using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Data
{
    public static class CountryDbData
    {
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                // Australia
                new Country { Id = 1, Name = "Australia", RegionID = 1, ImageFilename = "australia.jpg" },
                // Asia
                new Country { Id = 2, Name = "China", RegionID = 2, ImageFilename = "china.jpg" },
                new Country { Id = 3, Name = "India", RegionID = 2, ImageFilename = "india.jpg" },
                new Country { Id = 4, Name = "Japan", RegionID = 2, ImageFilename = "japan.jpg" },
                new Country { Id = 5, Name = "Malaysia", RegionID = 2, ImageFilename = "malaysia.jpg" },
                new Country { Id = 6, Name = "Philippines", RegionID = 2, ImageFilename = "philippines.jpg" },
                new Country { Id = 7, Name = "Singapore", RegionID = 2, ImageFilename = "singapore.jpg" },
                new Country { Id = 8, Name = "South Korea", RegionID = 2, ImageFilename = "south-korea.jpg" },
                new Country { Id = 9, Name = "Thailand", RegionID = 2, ImageFilename = "thailand.jpg" },
                new Country { Id = 10, Name = "Vietnam", RegionID = 2, ImageFilename = "vietnam.jpg" },
                new Country { Id = 37, Name = "Indonesia", RegionID = 2, ImageFilename = "no-image.jpg" },
                // Europe
                new Country { Id = 11, Name = "Belgium", RegionID = 3, ImageFilename = "no-image.jpg" },
                new Country { Id = 12, Name = "Denmark", RegionID = 3, ImageFilename = "denmark.jpg" },
                new Country { Id = 13, Name = "Finland", RegionID = 3, ImageFilename = "finland.jpg" },
                new Country { Id = 14, Name = "France", RegionID = 3, ImageFilename = "france.jpg" },
                new Country { Id = 15, Name = "Germany", RegionID = 3, ImageFilename = "germany.jpg" },
                new Country { Id = 16, Name = "Ireland", RegionID = 3, ImageFilename = "ireland.jpg" },
                new Country { Id = 17, Name = "Italy", RegionID = 3, ImageFilename = "italy.jpg" },
                new Country { Id = 18, Name = "Norway", RegionID = 3, ImageFilename = "norway.jpg" },
                new Country { Id = 19, Name = "United Kingdom", RegionID = 3, ImageFilename = "united-kingdom.jpg" },
                new Country { Id = 38, Name = "Greece", RegionID = 3, ImageFilename = "no-image.jpg" },
                // North America
                new Country { Id = 20, Name = "Bahamas", RegionID = 4, ImageFilename = "no-image.jpg" },
                new Country { Id = 21, Name = "Canada", RegionID = 4, ImageFilename = "canada.jpg" },
                new Country { Id = 22, Name = "Jamaica", RegionID = 4, ImageFilename = "jamaica.jpg" },
                new Country { Id = 23, Name = "Mexico", RegionID = 4, ImageFilename = "mexico.jpg" },
                new Country { Id = 24, Name = "United States", RegionID = 4, ImageFilename = "united-states.jpg" },
                new Country { Id = 39, Name = "Cuba", RegionID = 4, ImageFilename = "no-image.jpg" },
                new Country { Id = 40, Name = "Haiti", RegionID = 4, ImageFilename = "no-image.jpg" },
                new Country { Id = 41, Name = "Panama", RegionID = 4, ImageFilename = "no-image.jpg" },
                new Country { Id = 42, Name = "Costa Rica", RegionID = 4, ImageFilename = "no-image.jpg" },
                new Country { Id = 43, Name = "Barbados", RegionID = 4, ImageFilename = "no-image.jpg" },
                // South America
                new Country { Id = 25, Name = "Argentina", RegionID = 5, ImageFilename = "no-image.jpg" },
                new Country { Id = 26, Name = "Brazil", RegionID = 5, ImageFilename = "brazil.jpg" },
                new Country { Id = 27, Name = "Chile", RegionID = 5, ImageFilename = "chile.jpg" },
                new Country { Id = 28, Name = "Ecuador", RegionID = 5, ImageFilename = "ecuador.jpg" },
                new Country { Id = 29, Name = "Peru", RegionID = 5, ImageFilename = "peru.jpg" },
                new Country { Id = 44, Name = "Colombia", RegionID = 5, ImageFilename = "no-image.jpg" },
                new Country { Id = 45, Name = "Venezuela", RegionID = 5, ImageFilename = "no-image.jpg" },
                new Country { Id = 46, Name = "Guyana", RegionID = 5, ImageFilename = "no-image.jpg" },
                new Country { Id = 47, Name = "Uruguay", RegionID = 5, ImageFilename = "no-image.jpg" },
                new Country { Id = 48, Name = "Aruba", RegionID = 5, ImageFilename = "no-image.jpg" },
                // Africa
                new Country { Id = 30, Name = "Ethiopia", RegionID = 6, ImageFilename = "ethiopia.jpg" },
                new Country { Id = 31, Name = "Kenya", RegionID = 6, ImageFilename = "kenya.jpg" },
                new Country { Id = 32, Name = "Nigeria", RegionID = 6, ImageFilename = "nigeria.jpg" },
                new Country { Id = 33, Name = "Rwanda", RegionID = 6, ImageFilename = "rwanda.jpg" },
                new Country { Id = 34, Name = "South Africa", RegionID = 6, ImageFilename = "south-africa.jpg" },
                new Country { Id = 35, Name = "Zimbabwe", RegionID = 6, ImageFilename = "zimbabwe.jpg" },
                new Country { Id = 49, Name = "Madagascar", RegionID = 6, ImageFilename = "no-image.jpg" },
                new Country { Id = 50, Name = "Sudan", RegionID = 6, ImageFilename = "no-image.jpg" },
                new Country { Id = 51, Name = "South Sudan", RegionID = 6, ImageFilename = "no-image.jpg" },
                new Country { Id = 52, Name = "Sierra Leone", RegionID = 6, ImageFilename = "no-image.jpg" },
                // Antarctica
                new Country { Id = 36, Name = "Antarctica", RegionID = 7, ImageFilename = "no-image.jpg" }
            );
        }
    }
}
