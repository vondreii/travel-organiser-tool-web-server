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
                new Country { Id = 1, Name = "Australia", RegionID = 1 },
                // Asia
                new Country { Id = 2, Name = "China", RegionID = 2 },
                new Country { Id = 3, Name = "India", RegionID = 2 },
                new Country { Id = 4, Name = "Japan", RegionID = 2 },
                new Country { Id = 5, Name = "Malaysia", RegionID = 2 },
                new Country { Id = 6, Name = "Philippines", RegionID = 2 },
                new Country { Id = 7, Name = "Singapore", RegionID = 2 },
                new Country { Id = 8, Name = "South Korea", RegionID = 2 },
                new Country { Id = 9, Name = "Thailand", RegionID = 2 },
                new Country { Id = 10, Name = "Vietnam", RegionID = 2 },
                // Europe
                new Country { Id = 11, Name = "Belgium", RegionID = 3 },
                new Country { Id = 12, Name = "Denmark", RegionID = 3 },
                new Country { Id = 13, Name = "Finland", RegionID = 3 },
                new Country { Id = 14, Name = "France", RegionID = 3 },
                new Country { Id = 15, Name = "Germany", RegionID = 3 },
                new Country { Id = 16, Name = "Ireland", RegionID = 3 },
                new Country { Id = 17, Name = "Italy", RegionID = 3 },
                new Country { Id = 18, Name = "Norway", RegionID = 3 },
                new Country { Id = 19, Name = "United Kingdom", RegionID = 3 },
                // North America
                new Country { Id = 20, Name = "Bahamas", RegionID = 4 },
                new Country { Id = 21, Name = "Canada", RegionID = 4 },
                new Country { Id = 22, Name = "Jamaica", RegionID = 4 },
                new Country { Id = 23, Name = "Mexico", RegionID = 4 },
                new Country { Id = 24, Name = "United States", RegionID = 4 },
                // South America
                new Country { Id = 25, Name = "Argentina", RegionID = 5 },
                new Country { Id = 26, Name = "Brazil", RegionID = 5 },
                new Country { Id = 27, Name = "Chile", RegionID = 5 },
                new Country { Id = 28, Name = "Ecuador", RegionID = 5 },
                new Country { Id = 29, Name = "Peru", RegionID = 5 },
                // Africa
                new Country { Id = 30, Name = "Ethiopia", RegionID = 6 },
                new Country { Id = 31, Name = "Kenya", RegionID = 6 },
                new Country { Id = 32, Name = "Nigeria", RegionID = 6 },
                new Country { Id = 33, Name = "Rwanda", RegionID = 6 },
                new Country { Id = 34, Name = "South Africa", RegionID = 6 },
                new Country { Id = 35, Name = "Zimbabwe", RegionID = 6 },
                // Antarctica
                new Country { Id = 36, Name = "Antarctica", RegionID = 7 }
            );
        }
    }
}
