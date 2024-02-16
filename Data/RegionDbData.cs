using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Data
{
    public static class RegionDbData
    {
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>().HasData(
                new Region { Id = 1, Name = "Australia" },
                new Region { Id = 2, Name = "Asia" },
                new Region { Id = 3, Name = "Europe" },
                new Region { Id = 4, Name = "North America" },
                new Region { Id = 5, Name = "South America" },
                new Region { Id = 6, Name = "Africa" },
                new Region { Id = 7, Name = "Antarctica" }
            );
        }
    }
}
