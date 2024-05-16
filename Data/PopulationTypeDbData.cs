using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Data
{
    public static class PopulationTypeDbData
    {
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PopulationType>().HasData(
                new PopulationType { Id = 1, Name = "City" },
                new PopulationType { Id = 2, Name = "Town" },
                new PopulationType { Id = 3, Name = "Rural (Non Urban)" }
            );
        }
    }
}
