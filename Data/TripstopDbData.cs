using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Data
{
    public static class TripstopDbData
    {
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tripstop>().HasData(
                new Tripstop { Id = 1, TripID = 1, DestinationID = 1001, Startdate = DateTime.Today, Enddate = DateTime.Today },
                new Tripstop { Id = 2, TripID = 1, DestinationID = 1002, Startdate = DateTime.Today, Enddate = DateTime.Today },
                new Tripstop { Id = 3, TripID = 2, DestinationID = 1003, Startdate = DateTime.Today, Enddate = DateTime.Today },
                new Tripstop { Id = 4, TripID = 2, DestinationID = 1004, Startdate = DateTime.Today, Enddate = DateTime.Today }
            );
        }
    }
}
