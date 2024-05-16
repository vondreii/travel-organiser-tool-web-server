using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Data
{
    public static class ClimateTypeDbData
    {
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClimateType>().HasData(
                new ClimateType { Id = 1, Name = "Sunny" },
                new ClimateType { Id = 2, Name = "Tropical" },
                new ClimateType { Id = 3, Name = "Chilly" },
                new ClimateType { Id = 4, Name = "Snowy" }
            );
        }
    }
}
