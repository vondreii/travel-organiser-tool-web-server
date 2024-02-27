using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Data
{
    public static class DestinationDbData
    {
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Destination>().HasData(
                // Australia
                new Destination { Id = 1, Name = "Adelaide", CountryID = 1 },
                new Destination { Id = 2, Name = "Brisbane", CountryID = 1 },
                new Destination { Id = 3, Name = "Canberra", CountryID = 1 },
                new Destination { Id = 4, Name = "Hobart", CountryID = 1 },
                new Destination { Id = 5, Name = "Melbourne", CountryID = 1 },
                new Destination { Id = 6, Name = "Sydney", CountryID = 1 },
                new Destination { Id = 7, Name = "Perth", CountryID = 1 },
                // Asia - China
                new Destination { Id = 8, Name = "Beijing", CountryID = 2 },
                new Destination { Id = 9, Name = "Shanghai", CountryID = 2 },
                // Asia - India
                new Destination { Id = 10, Name = "Mumbai", CountryID = 3 },
                new Destination { Id = 11, Name = "Kolkata", CountryID = 3 },
                new Destination { Id = 12, Name = "Hyderabad", CountryID = 3 },
                // Asia - Japan
                new Destination { Id = 13, Name = "Tokyo", CountryID = 4 },
                new Destination { Id = 14, Name = "Osaka", CountryID = 4 },
                new Destination { Id = 15, Name = "Hiroshima", CountryID = 4 },
                // Asia - Malaysia
                new Destination { Id = 16, Name = "Kuala Lumpur", CountryID = 5 },
                // Asia - Philippines
                new Destination { Id = 17, Name = "Manila", CountryID = 6 },
                // Asia - Singapore
                new Destination { Id = 18, Name = "Singapore", CountryID = 7 },
                // Asia - South Korea
                new Destination { Id = 19, Name = "Seoul", CountryID = 8 },
                // Asia - Thailand
                new Destination { Id = 20, Name = "Bangkok", CountryID = 9 },
                new Destination { Id = 21, Name = "Phuket", CountryID = 9 },
                // Asia - Vietnam
                new Destination { Id = 22, Name = "Ho Chi Minh City", CountryID = 10 },
                new Destination { Id = 23, Name = "Hanoi", CountryID = 10 },
                // Europe - Belgium
                new Destination { Id = 24, Name = "Brussels", CountryID = 11 },
                new Destination { Id = 25, Name = "Bruges", CountryID = 11 },
                // Europe - Denmark
                new Destination { Id = 26, Name = "Copenhagen", CountryID = 12 },
                // Europe - Finland
                new Destination { Id = 27, Name = "Helsinki", CountryID = 13 },
                // Europe - France
                new Destination { Id = 28, Name = "Paris", CountryID = 14 },
                // Europe - Germany
                new Destination { Id = 29, Name = "Berlin", CountryID = 15 },
                // Europe - Ireland
                new Destination { Id = 30, Name = "Dublin", CountryID = 16 },
                new Destination { Id = 31, Name = "Galway", CountryID = 16 },
                // Europe - Italy
                new Destination { Id = 32, Name = "Rome", CountryID = 17 },
                new Destination { Id = 33, Name = "Venice", CountryID = 17 },
                new Destination { Id = 34, Name = "Florence", CountryID = 17 },
                // Europe - Norway
                new Destination { Id = 35, Name = "Oslo", CountryID = 18 },
                // Europe - United Kingdom
                new Destination { Id = 36, Name = "London", CountryID = 19 },
                new Destination { Id = 37, Name = "Bristol", CountryID = 19 },
                new Destination { Id = 38, Name = "Manchester", CountryID = 19 },
                new Destination { Id = 39, Name = "Birmingham", CountryID = 19 },
                // North America - Bahamas
                new Destination { Id = 40, Name = "Nassau", CountryID = 20 },
                // North America - Canada
                new Destination { Id = 41, Name = "Toronto", CountryID = 21 },
                new Destination { Id = 42, Name = "Vancouver", CountryID = 21 },
                // North America - Jamaica
                new Destination { Id = 43, Name = "Montego Bay", CountryID = 22 },
                // North America - Mexico
                new Destination { Id = 44, Name = "Mexico City", CountryID = 23 },
                // North America - United States
                new Destination { Id = 45, Name = "Boston", CountryID = 24 },
                new Destination { Id = 46, Name = "Chicago", CountryID = 24 },
                new Destination { Id = 47, Name = "Los Angeles", CountryID = 24 },
                new Destination { Id = 48, Name = "New York", CountryID = 24 },
                // South America - Argentina
                new Destination { Id = 49, Name = "Buenos Aires", CountryID = 25 },
                // South America - Brazil
                new Destination { Id = 50, Name = "Rio de Janeiro", CountryID = 26 },
                new Destination { Id = 51, Name = "Salvador", CountryID = 26 },
                new Destination { Id = 52, Name = "Sao Paulo", CountryID = 26 },
                // South America - Chile
                new Destination { Id = 53, Name = "Santiago", CountryID = 27 },
                // South America - Ecuador
                new Destination { Id = 54, Name = "Quito", CountryID = 28 },
                // South America - Peru
                new Destination { Id = 55, Name = "Arequipa", CountryID = 29 },
                // Africa - Ethiopia
                new Destination { Id = 56, Name = "Addis Ababa", CountryID = 30 },
                // Africa - Kenya
                new Destination { Id = 57, Name = "Nairobi", CountryID = 31 },
                // Africa - Nigeria
                new Destination { Id = 58, Name = "Lagos", CountryID = 32 },
                // Africa - Rwanda
                new Destination { Id = 59, Name = "Kigali", CountryID = 33 },
                // Africa - South Africa
                new Destination { Id = 60, Name = "Johannesburg", CountryID = 34 },
                // Africa - Zimbabwe
                new Destination { Id = 61, Name = "Harare", CountryID = 35 },
                // Antarctica
                new Destination { Id = 62, Name = "McMurdo Station", CountryID = 36 }
            );
        }
    }
}
