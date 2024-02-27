using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Data
{
    public static class TripDbData
    {
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>().HasData(
                new Trip { Id = 1, Name = "Example Trip: Visiting Family in Sydney", DestinationID = 1 },
                new Trip { Id = 2, Name = "Example Trip: Visiting Tokyo", DestinationID = 2 }
            );
        }
    }
}
