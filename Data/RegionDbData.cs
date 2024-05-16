using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Data
{
    public static class RegionDbData
    {
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>().HasData(
                new Region { Id = 1, Name = "Oceania" },

                new Region { Id = 2, Name = "South East Asia" },
                new Region { Id = 3, Name = "East Asia" },
                new Region { Id = 4, Name = "South Asia" },
                new Region { Id = 5, Name = "Middle East" },
                
                new Region { Id = 6, Name = "Scandinavia" },
                new Region { Id = 7, Name = "United Kingdom and Western Europe" },
                new Region { Id = 8, Name = "Central Europe" },
                new Region { Id = 9, Name = "Southern Europe" },
                new Region { Id = 17, Name = "Eastern Europe and Former USSR" },

                new Region { Id = 10, Name = "Northern Africa" },
                new Region { Id = 11, Name = "Subsaharan Africa" },
                
                new Region { Id = 12, Name = "North America" },
                new Region { Id = 13, Name = "Central America" },
                new Region { Id = 14, Name = "Caribbean" },
                new Region { Id = 15, Name = "South America" },
                
                new Region { Id = 16, Name = "South Pole" }
            );
        }
    }
}
