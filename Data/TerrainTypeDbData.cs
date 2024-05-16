using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Data
{
    public static class TerrainTypeDbData
    {
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TerrainType>().HasData(
                new TerrainType { Id = 1, Name = "Major Cities" },
                new TerrainType { Id = 2, Name = "Desert" },
                new TerrainType { Id = 3, Name = "Forest" },
                new TerrainType { Id = 4, Name = "Cliffs" },
                new TerrainType { Id = 5, Name = "Hills" },
                new TerrainType { Id = 6, Name = "Marsh" },
                new TerrainType { Id = 7, Name = "Farmland" },
                new TerrainType { Id = 8, Name = "Beach" },
                new TerrainType { Id = 9, Name = "Coastal" },
                new TerrainType { Id = 10, Name = "Waterfront" },
                new TerrainType { Id = 11, Name = "Mountains" }
            );
        }
    }
}
