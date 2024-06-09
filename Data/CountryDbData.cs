using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
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
                // South East Asia
                new Country { Id = 2, RegionID = 2, Name = "Malaysia", ImageFilename = "malaysia.jpg" },
                new Country { Id = 3, RegionID = 2, Name = "Philippines", ImageFilename = "philippines.jpg" },
                new Country { Id = 4, RegionID = 2, Name = "Singapore", ImageFilename = "singapore.jpg" },
                new Country { Id = 5, RegionID = 2, Name = "Thailand", ImageFilename = "thailand.jpg" },
                new Country { Id = 6, RegionID = 2, Name = "Vietnam", ImageFilename = "vietnam.jpg" },
                // East Asia
                new Country { Id = 7, RegionID = 3, Name = "China", ImageFilename = "china.jpg" },
                new Country { Id = 8, RegionID = 3, Name = "Japan", ImageFilename = "japan.jpg" },
                new Country { Id = 9, RegionID = 3, Name = "South Korea", ImageFilename = "south-korea.jpg" },
                // South Asia
                new Country { Id = 10, RegionID = 4, Name = "India", ImageFilename = "india.jpg" },
                // Middle East
                new Country { Id = 11, RegionID = 5, Name = "Kuwait", ImageFilename = "no-image.jpg" },
                new Country { Id = 12, RegionID = 5, Name = "United Arab Emirates", ImageFilename = "no-image.jpg" },
                // Scandinavia
                new Country { Id = 13, RegionID = 6, Name = "Denmark", ImageFilename = "denmark.jpg" },
                new Country { Id = 14, RegionID = 6, Name = "Finland", ImageFilename = "finland.jpg" },
                new Country { Id = 15, RegionID = 6, Name = "Norway", ImageFilename = "norway.jpg" },
                // United Kingdom and Western Europe
                new Country { Id = 16, RegionID = 7, Name = "United Kingdom", ImageFilename = "united-kingdom.jpg" },
                new Country { Id = 17, RegionID = 7, Name = "Ireland", ImageFilename = "ireland.jpg" },
                // Central Europe
                new Country { Id = 18, RegionID = 8, Name = "Belgium", ImageFilename = "no-image.jpg" },
                new Country { Id = 19, RegionID = 8, Name = "France", ImageFilename = "france.jpg" },
                new Country { Id = 20, RegionID = 8, Name = "Germany", ImageFilename = "germany.jpg" },
                // Southern Europe
                new Country { Id = 21, RegionID = 9, Name = "Italy", ImageFilename = "italy.jpg" },
                // Eastern Europe and Former USSR
                new Country { Id = 22, RegionID = 17, Name = "Russia", ImageFilename = "no-image.jpg" },
                // Northern Africa
                new Country { Id = 23, RegionID = 10, Name = "Sudan", ImageFilename = "no-image.jpg" },
                // Subsaharan Africa
                new Country { Id = 24, RegionID = 11, Name = "Kenya", ImageFilename = "kenya.jpg" },
                new Country { Id = 25, RegionID = 11, Name = "Rwanda", ImageFilename = "rwanda.jpg" },
                new Country { Id = 26, RegionID = 11, Name = "South Africa", ImageFilename = "south-africa.jpg" },
                // North America
                new Country { Id = 27, RegionID = 12, Name = "Canada", ImageFilename = "canada.jpg" },
                new Country { Id = 28, RegionID = 12, Name = "Mexico", ImageFilename = "mexico.jpg" },
                new Country { Id = 29, RegionID = 12, Name = "United States", ImageFilename = "united-states.jpg" },
                // Central America
                new Country { Id = 30, RegionID = 13, Name = "Costa Rica", ImageFilename = "no-image.jpg" },
                // Caribbean
                new Country { Id = 31, RegionID = 14, Name = "Jamaica", ImageFilename = "jamaica.jpg" },
                // South America
                new Country { Id = 32, RegionID = 15, Name = "Brazil", ImageFilename = "brazil.jpg" },
                new Country { Id = 33, RegionID = 15, Name = "Chile", ImageFilename = "chile.jpg" },
                new Country { Id = 34, RegionID = 15, Name = "Ecuador", ImageFilename = "ecuador.jpg" },
                new Country { Id = 35, RegionID = 15, Name = "Peru", ImageFilename = "peru.jpg" },
                // Antarctica
                new Country { Id = 36, RegionID = 16, Name = "Antarctica", ImageFilename = "no-image.jpg" }
            );
        }
    }
}
