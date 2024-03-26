using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Data
{
    public static class TripstopDbData
    {
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tripstop>().HasData(
                new Tripstop { Id = 1, TripID = 1, DestinationID = 6, Startdate = DateTime.MinValue, Enddate = DateTime.MinValue },
                new Tripstop { Id = 2, TripID = 1, DestinationID = 5, Startdate = DateTime.MinValue, Enddate = DateTime.MinValue },
                new Tripstop { Id = 3, TripID = 2, DestinationID = 13, Startdate = DateTime.MinValue, Enddate = DateTime.MinValue },
                new Tripstop { Id = 4, TripID = 2, DestinationID = 19, Startdate = DateTime.MinValue, Enddate = DateTime.MinValue }
            );
        }
    }
}
