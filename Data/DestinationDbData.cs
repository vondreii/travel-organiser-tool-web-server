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
                new Destination { Id = 1, Name = "Adelaide", CountryID = 1, ImageFilename = "adelaide.jpg" },
                new Destination { Id = 2, Name = "Brisbane", CountryID = 1, ImageFilename = "brisbane.jpg" },
                new Destination { Id = 3, Name = "Canberra", CountryID = 1, ImageFilename = "canberra.jpg" },
                new Destination { Id = 4, Name = "Hobart", CountryID = 1, ImageFilename = "hobart.jpg" },
                new Destination { Id = 5, Name = "Melbourne", CountryID = 1, ImageFilename = "melbourne.jpg" },
                new Destination { Id = 6, Name = "Sydney", CountryID = 1, ImageFilename = "sydney.jpg" },
                new Destination { Id = 7, Name = "Perth", CountryID = 1, ImageFilename = "perth.jpg" },
                // Asia - China
                new Destination { Id = 8, Name = "Beijing", CountryID = 2, ImageFilename = "beijing.jpg" },
                new Destination { Id = 9, Name = "Shanghai", CountryID = 2, ImageFilename = "shanghai.jpg" },
                // Asia - India
                new Destination { Id = 10, Name = "Mumbai", CountryID = 3, ImageFilename = "mumbai.jpg" },
                new Destination { Id = 11, Name = "Kolkata", CountryID = 3, ImageFilename = "kolkata.jpg" },
                new Destination { Id = 12, Name = "Hyderabad", CountryID = 3, ImageFilename = "hyderabad.jpg" },
                // Asia - Japan
                new Destination { Id = 13, Name = "Tokyo", CountryID = 4, ImageFilename = "tokyo.jpg" },
                new Destination { Id = 14, Name = "Osaka", CountryID = 4, ImageFilename = "osaka.jpg" },
                new Destination { Id = 15, Name = "Hiroshima", CountryID = 4, ImageFilename = "hiroshima.jpg" },
                // Asia - Malaysia
                new Destination { Id = 16, Name = "Kuala Lumpur", CountryID = 5, ImageFilename = "kuala-lumpur.jpg" },
                // Asia - Philippines
                new Destination { Id = 17, Name = "Manila", CountryID = 6, ImageFilename = "manila.jpg" },
                // Asia - Singapore
                new Destination { Id = 18, Name = "Singapore", CountryID = 7, ImageFilename = "singapore.jpg" },
                // Asia - South Korea
                new Destination { Id = 19, Name = "Seoul", CountryID = 8, ImageFilename = "seoul.jpg" },
                // Asia - Thailand
                new Destination { Id = 20, Name = "Bangkok", CountryID = 9, ImageFilename = "bangkok.jpg" },
                new Destination { Id = 21, Name = "Phuket", CountryID = 9, ImageFilename = "phuket.jpg" },
                // Asia - Vietnam
                new Destination { Id = 22, Name = "Ho Chi Minh City", CountryID = 10, ImageFilename = "ho-chi-minh-city.jpg" },
                new Destination { Id = 23, Name = "Hanoi", CountryID = 10, ImageFilename = "hanoi.jpg" },
                // Europe - Belgium
                new Destination { Id = 24, Name = "Brussels", CountryID = 11, ImageFilename = "brussels.jpg" },
                new Destination { Id = 25, Name = "Bruges", CountryID = 11, ImageFilename = "bruges.jpg" },
                // Europe - Denmark
                new Destination { Id = 26, Name = "Copenhagen", CountryID = 12, ImageFilename = "copenhagen.jpg" },
                // Europe - Finland
                new Destination { Id = 27, Name = "Helsinki", CountryID = 13, ImageFilename = "helsinki.jpg" },
                // Europe - France
                new Destination { Id = 28, Name = "Paris", CountryID = 14, ImageFilename = "paris.jpg" },
                // Europe - Germany
                new Destination { Id = 29, Name = "Berlin", CountryID = 15, ImageFilename = "berlin.jpg" },
                // Europe - Ireland
                new Destination { Id = 30, Name = "Dublin", CountryID = 16, ImageFilename = "dublin.jpg" },
                new Destination { Id = 31, Name = "Galway", CountryID = 16, ImageFilename = "galway.jpg" },
                // Europe - Italy
                new Destination { Id = 32, Name = "Rome", CountryID = 17, ImageFilename = "rome.jpg" },
                new Destination { Id = 33, Name = "Venice", CountryID = 17, ImageFilename = "venice.jpg" },
                new Destination { Id = 34, Name = "Florence", CountryID = 17, ImageFilename = "florence.jpg" },
                // Europe - Norway
                new Destination { Id = 35, Name = "Oslo", CountryID = 18, ImageFilename = "oslo.jpg" },
                // Europe - United Kingdom
                new Destination { Id = 36, Name = "London", CountryID = 19, ImageFilename = "london.jpg" },
                new Destination { Id = 37, Name = "Bristol", CountryID = 19, ImageFilename = "bristol.jpg" },
                new Destination { Id = 38, Name = "Manchester", CountryID = 19, ImageFilename = "manchester.jpg" },
                new Destination { Id = 39, Name = "Birmingham", CountryID = 19, ImageFilename = "birmingham.jpg" },
                // North America - Bahamas
                new Destination { Id = 40, Name = "Nassau", CountryID = 20, ImageFilename = "nassau.jpg" },
                // North America - Canada
                new Destination { Id = 41, Name = "Toronto", CountryID = 21, ImageFilename = "toronto.jpg" },
                new Destination { Id = 42, Name = "Vancouver", CountryID = 21, ImageFilename = "vancouver.jpg" },
                // North America - Jamaica
                new Destination { Id = 43, Name = "Montego Bay", CountryID = 22, ImageFilename = "montego-bay.jpg" },
                // North America - Mexico
                new Destination { Id = 44, Name = "Mexico City", CountryID = 23, ImageFilename = "mexico-city.jpg" },
                // North America - United States
                new Destination { Id = 45, Name = "Boston", CountryID = 24, ImageFilename = "boston.jpg" },
                new Destination { Id = 46, Name = "Chicago", CountryID = 24, ImageFilename = "chicago.jpg" },
                new Destination { Id = 47, Name = "Los Angeles", CountryID = 24, ImageFilename = "los-angeles.jpg" },
                new Destination { Id = 48, Name = "New York", CountryID = 24, ImageFilename = "new-york.jpg" },
                // South America - Argentina
                new Destination { Id = 49, Name = "Buenos Aires", CountryID = 25, ImageFilename = "buenos-aires.jpg" },
                // South America - Brazil
                new Destination { Id = 50, Name = "Rio de Janeiro", CountryID = 26, ImageFilename = "rio-de-janeiro.jpg" },
                new Destination { Id = 51, Name = "Salvador", CountryID = 26, ImageFilename = "salvador.jpg" },
                new Destination { Id = 52, Name = "Sao Paulo", CountryID = 26, ImageFilename = "sao-paulo.jpg" },
                // South America - Chile
                new Destination { Id = 53, Name = "Santiago", CountryID = 27, ImageFilename = "santiago.jpg" },
                // South America - Ecuador
                new Destination { Id = 54, Name = "Quito", CountryID = 28, ImageFilename = "quito.jpg" },
                // South America - Peru
                new Destination { Id = 55, Name = "Arequipa", CountryID = 29, ImageFilename = "arequipa.jpg" },
                // Africa - Ethiopia
                new Destination { Id = 56, Name = "Addis Ababa", CountryID = 30, ImageFilename = "addis-ababa.jpg" },
                // Africa - Kenya
                new Destination { Id = 57, Name = "Nairobi", CountryID = 31, ImageFilename = "nairobi.jpg" },
                // Africa - Nigeria
                new Destination { Id = 58, Name = "Lagos", CountryID = 32, ImageFilename = "lagos.jpg" },
                // Africa - Rwanda
                new Destination { Id = 59, Name = "Kigali", CountryID = 33, ImageFilename = "kigali.jpg" },
                // Africa - South Africa
                new Destination { Id = 60, Name = "Johannesburg", CountryID = 34, ImageFilename = "johannesburg.jpg" },
                // Africa - Zimbabwe
                new Destination { Id = 61, Name = "Harare", CountryID = 35, ImageFilename = "harare.jpg" },
                // Antarctica
                new Destination { Id = 62, Name = "McMurdo Station", CountryID = 36, ImageFilename = "mcmurdo-station.jpg" }
            );
        }
    }
}
