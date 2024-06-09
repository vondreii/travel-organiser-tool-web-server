using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Data
{
    public static class TripstopDbData
    {
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tripstop>().HasData(
                new Tripstop { Id = 1, TripID = 1, DestinationID = 1, Startdate = DateTime.Today, Enddate = DateTime.Today },
                new Tripstop { Id = 2, TripID = 1, DestinationID = 2, Startdate = DateTime.Today, Enddate = DateTime.Today },
                new Tripstop { Id = 3, TripID = 2, DestinationID = 3, Startdate = DateTime.Today, Enddate = DateTime.Today },
                new Tripstop { Id = 4, TripID = 2, DestinationID = 4, Startdate = DateTime.Today, Enddate = DateTime.Today }
            );
        }
    }
}
