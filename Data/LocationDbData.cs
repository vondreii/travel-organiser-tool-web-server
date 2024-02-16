using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Data
{
    public static class LocationDbData
    {
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasData(
                // Australia
                new Location { Id = 1, Name = "Adelaide", CountryID = 1 },
                new Location { Id = 2, Name = "Brisbane", CountryID = 1 },
                new Location { Id = 3, Name = "Canberra", CountryID = 1 },
                new Location { Id = 4, Name = "Hobart", CountryID = 1 },
                new Location { Id = 5, Name = "Melbourne", CountryID = 1 },
                new Location { Id = 6, Name = "Sydney", CountryID = 1 },
                new Location { Id = 7, Name = "Perth", CountryID = 1 },
                // Asia - China
                new Location { Id = 8, Name = "Beijing", CountryID = 2 },
                new Location { Id = 9, Name = "Shanghai", CountryID = 2 },
                // Asia - India
                new Location { Id = 10, Name = "Mumbai", CountryID = 3 },
                new Location { Id = 11, Name = "Kolkata", CountryID = 3 },
                new Location { Id = 12, Name = "Hyderabad", CountryID = 3 },
                // Asia - Japan
                new Location { Id = 13, Name = "Tokyo", CountryID = 4 },
                new Location { Id = 14, Name = "Osaka", CountryID = 4 },
                new Location { Id = 15, Name = "Hiroshima", CountryID = 4 },
                // Asia - Malaysia
                new Location { Id = 16, Name = "Kuala Lumpur", CountryID = 5 },
                // Asia - Philippines
                new Location { Id = 17, Name = "Manila", CountryID = 6 },
                // Asia - Singapore
                new Location { Id = 18, Name = "Singapore", CountryID = 7 },
                // Asia - South Korea
                new Location { Id = 19, Name = "Seoul", CountryID = 8 },
                // Asia - Thailand
                new Location { Id = 20, Name = "Bangkok", CountryID = 9 },
                new Location { Id = 21, Name = "Phuket", CountryID = 9 },
                // Asia - Vietnam
                new Location { Id = 22, Name = "Ho Chi Minh City", CountryID = 10 },
                new Location { Id = 23, Name = "Hanoi", CountryID = 10 },
                // Europe - Belgium
                new Location { Id = 24, Name = "Brussels", CountryID = 11 },
                new Location { Id = 25, Name = "Bruges", CountryID = 11 },
                // Europe - Denmark
                new Location { Id = 26, Name = "Copenhagen", CountryID = 12 },
                // Europe - Finland
                new Location { Id = 27, Name = "Helsinki", CountryID = 13 },
                // Europe - France
                new Location { Id = 28, Name = "Paris", CountryID = 14 },
                // Europe - Germany
                new Location { Id = 29, Name = "Berlin", CountryID = 15 },
                // Europe - Ireland
                new Location { Id = 30, Name = "Dublin", CountryID = 16 },
                new Location { Id = 31, Name = "Galway", CountryID = 16 },
                // Europe - Italy
                new Location { Id = 32, Name = "Rome", CountryID = 17 },
                new Location { Id = 33, Name = "Venice", CountryID = 17 },
                new Location { Id = 34, Name = "Florence", CountryID = 17 },
                // Europe - Norway
                new Location { Id = 35, Name = "Oslo", CountryID = 18 },
                // Europe - United Kingdom
                new Location { Id = 36, Name = "London", CountryID = 19 },
                new Location { Id = 37, Name = "Bristol", CountryID = 19 },
                new Location { Id = 38, Name = "Manchester", CountryID = 19 },
                new Location { Id = 39, Name = "Birmingham", CountryID = 19 },
                // North America - Bahamas
                new Location { Id = 40, Name = "Nassau", CountryID = 20 },
                // North America - Canada
                new Location { Id = 41, Name = "Toronto", CountryID = 21 },
                new Location { Id = 42, Name = "Vancouver", CountryID = 21 },
                // North America - Jamaica
                new Location { Id = 43, Name = "Montego Bay", CountryID = 22 },
                // North America - Mexico
                new Location { Id = 44, Name = "Mexico City", CountryID = 23 },
                // North America - United States
                new Location { Id = 45, Name = "Boston", CountryID = 24 },
                new Location { Id = 46, Name = "Chicago", CountryID = 24 },
                new Location { Id = 47, Name = "Los Angeles", CountryID = 24 },
                new Location { Id = 48, Name = "New York", CountryID = 24 },
                // South America - Argentina
                new Location { Id = 49, Name = "Buenos Aires", CountryID = 25 },
                // South America - Brazil
                new Location { Id = 50, Name = "Rio de Janeiro", CountryID = 26 },
                new Location { Id = 51, Name = "Salvador", CountryID = 26 },
                new Location { Id = 52, Name = "Sao Paulo", CountryID = 26 },
                // South America - Chile
                new Location { Id = 53, Name = "Santiago", CountryID = 27 },
                // South America - Ecuador
                new Location { Id = 54, Name = "Quito", CountryID = 28 },
                // South America - Peru
                new Location { Id = 55, Name = "Arequipa", CountryID = 29 },
                // Africa - Ethiopia
                new Location { Id = 56, Name = "Addis Ababa", CountryID = 30 },
                // Africa - Kenya
                new Location { Id = 57, Name = "Nairobi", CountryID = 31 },
                // Africa - Nigeria
                new Location { Id = 58, Name = "Lagos", CountryID = 32 },
                // Africa - Rwanda
                new Location { Id = 59, Name = "Kigali", CountryID = 33 },
                // Africa - South Africa
                new Location { Id = 60, Name = "Johannesburg", CountryID = 34 },
                // Africa - Zimbabwe
                new Location { Id = 61, Name = "Harare", CountryID = 35 },
                // Antarctica
                new Location { Id = 62, Name = "McMurdo Station", CountryID = 36 }
            );
        }
    }
}
