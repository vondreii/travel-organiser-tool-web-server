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
                new Destination { Id = 1, CountryID = 1, Name = "Adelaide", ImageFilename = "adelaide.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 2, CountryID = 1, Name = "Brisbane", ImageFilename = "brisbane.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 3, CountryID = 1, Name = "Canberra", ImageFilename = "canberra.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 4, CountryID = 1, Name = "Hobart", ImageFilename = "hobart.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 5, CountryID = 1, Name = "Melbourne", ImageFilename = "melbourne.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 6, CountryID = 1, Name = "Sydney", ImageFilename = "sydney.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 7, CountryID = 1, Name = "Perth", ImageFilename = "perth.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 8, CountryID = 1, Name = "Newcastle", ImageFilename = "no-image.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 9 },
                new Destination { Id = 9, CountryID = 1, Name = "Central Coast", ImageFilename = "no-image.jpg", PopulationTypeID = 2, ClimateTypeID = 1, TerrainTypeID = 9 },
                new Destination { Id = 10, CountryID = 1, Name = "Hunter Valley", ImageFilename = "no-image.jpg", PopulationTypeID = 2, ClimateTypeID = 1, TerrainTypeID = 7 },
                new Destination { Id = 11, CountryID = 1, Name = "Nelson Bay", ImageFilename = "no-image.jpg", PopulationTypeID = 2, ClimateTypeID = 1, TerrainTypeID = 9 },
                new Destination { Id = 12, CountryID = 1, Name = "Port Macquarie", ImageFilename = "no-image.jpg", PopulationTypeID = 2, ClimateTypeID = 1, TerrainTypeID = 9 }

                // South East Asia
                // new Destination { Id = 16, Name = "Kuala Lumpur", CountryID = 5, ImageFilename = "kuala-lumpur.jpg" },
                // new Destination { Id = 17, Name = "Manila", CountryID = 6, ImageFilename = "manila.jpg" },
                // new Destination { Id = 18, Name = "Singapore", CountryID = 7, ImageFilename = "singapore.jpg" },
                // new Destination { Id = 20, Name = "Bangkok", CountryID = 9, ImageFilename = "bangkok.jpg" },
                // new Destination { Id = 21, Name = "Phuket", CountryID = 9, ImageFilename = "phuket.jpg" },
                // new Destination { Id = 22, Name = "Ho Chi Minh City", CountryID = 10, ImageFilename = "ho-chi-minh-city.jpg" },
                // new Destination { Id = 23, Name = "Hanoi", CountryID = 10, ImageFilename = "hanoi.jpg" },
                // new Destination { Id = 63, Name = "Jakarta", CountryID = 37, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 64, Name = "Bali", CountryID = 37, ImageFilename = "no-image.jpg" },

                // East Asia
                // new Destination { Id = 8, Name = "Beijing", CountryID = 2, ImageFilename = "beijing.jpg" },
                // new Destination { Id = 9, Name = "Shanghai", CountryID = 2, ImageFilename = "shanghai.jpg" },
                // new Destination { Id = 13, Name = "Tokyo", CountryID = 4, ImageFilename = "tokyo.jpg" },
                // new Destination { Id = 14, Name = "Osaka", CountryID = 4, ImageFilename = "osaka.jpg" },
                // new Destination { Id = 15, Name = "Hiroshima", CountryID = 4, ImageFilename = "hiroshima.jpg" },
                // new Destination { Id = 19, Name = "Seoul", CountryID = 8, ImageFilename = "seoul.jpg" },
                // 
                // // South Asia
                // new Destination { Id = 10, Name = "Mumbai", CountryID = 3, ImageFilename = "mumbai.jpg" },
                // new Destination { Id = 11, Name = "Kolkata", CountryID = 3, ImageFilename = "kolkata.jpg" },
                // new Destination { Id = 12, Name = "Hyderabad", CountryID = 3, ImageFilename = "hyderabad.jpg" }

                // // Europe
                // new Destination { Id = 24, Name = "Brussels", CountryID = 11, ImageFilename = "brussels.jpg" },
                // new Destination { Id = 25, Name = "Bruges", CountryID = 11, ImageFilename = "bruges.jpg" },
                // new Destination { Id = 26, Name = "Copenhagen", CountryID = 12, ImageFilename = "copenhagen.jpg" },
                // new Destination { Id = 27, Name = "Helsinki", CountryID = 13, ImageFilename = "helsinki.jpg" },
                // new Destination { Id = 28, Name = "Paris", CountryID = 14, ImageFilename = "paris.jpg" },
                // new Destination { Id = 29, Name = "Berlin", CountryID = 15, ImageFilename = "berlin.jpg" },
                // new Destination { Id = 30, Name = "Dublin", CountryID = 16, ImageFilename = "dublin.jpg" },
                // new Destination { Id = 31, Name = "Galway", CountryID = 16, ImageFilename = "galway.jpg" },
                // new Destination { Id = 32, Name = "Rome", CountryID = 17, ImageFilename = "rome.jpg" },
                // new Destination { Id = 33, Name = "Venice", CountryID = 17, ImageFilename = "venice.jpg" },
                // new Destination { Id = 34, Name = "Florence", CountryID = 17, ImageFilename = "florence.jpg" },
                // new Destination { Id = 35, Name = "Oslo", CountryID = 18, ImageFilename = "oslo.jpg" },
                // new Destination { Id = 36, Name = "London", CountryID = 19, ImageFilename = "london.jpg" },
                // new Destination { Id = 37, Name = "Bristol", CountryID = 19, ImageFilename = "bristol.jpg" },
                // new Destination { Id = 38, Name = "Manchester", CountryID = 19, ImageFilename = "manchester.jpg" },
                // new Destination { Id = 39, Name = "Birmingham", CountryID = 19, ImageFilename = "birmingham.jpg" },
                // new Destination { Id = 65, Name = "Athens", CountryID = 38, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 66, Name = "Rhodes", CountryID = 38, ImageFilename = "no-image.jpg" },
                // // North America
                // new Destination { Id = 40, Name = "Nassau", CountryID = 20, ImageFilename = "nassau.jpg" },
                // new Destination { Id = 41, Name = "Toronto", CountryID = 21, ImageFilename = "toronto.jpg" },
                // new Destination { Id = 42, Name = "Vancouver", CountryID = 21, ImageFilename = "vancouver.jpg" },
                // new Destination { Id = 43, Name = "Montego Bay", CountryID = 22, ImageFilename = "montego-bay.jpg" },
                // new Destination { Id = 44, Name = "Mexico City", CountryID = 23, ImageFilename = "mexico-city.jpg" },
                // new Destination { Id = 45, Name = "Boston", CountryID = 24, ImageFilename = "boston.jpg" },
                // new Destination { Id = 46, Name = "Chicago", CountryID = 24, ImageFilename = "chicago.jpg" },
                // new Destination { Id = 47, Name = "Los Angeles", CountryID = 24, ImageFilename = "los-angeles.jpg" },
                // new Destination { Id = 48, Name = "New York", CountryID = 24, ImageFilename = "new-york.jpg" },
                // new Destination { Id = 67, Name = "Havana", CountryID = 39, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 68, Name = "Santa Clara", CountryID = 39, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 69, Name = "Port-au-Prince", CountryID = 40, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 70, Name = "Petion-Ville", CountryID = 40, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 71, Name = "Panama City", CountryID = 41, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 72, Name = "Santiago", CountryID = 41, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 73, Name = "San Jose", CountryID = 42, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 74, Name = "Cartago", CountryID = 42, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 75, Name = "Bridgetown", CountryID = 43, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 76, Name = "Saint James", CountryID = 43, ImageFilename = "no-image.jpg" },
                // // South America
                // new Destination { Id = 49, Name = "Buenos Aires", CountryID = 25, ImageFilename = "buenos-aires.jpg" },
                // new Destination { Id = 50, Name = "Rio de Janeiro", CountryID = 26, ImageFilename = "rio-de-janeiro.jpg" },
                // new Destination { Id = 51, Name = "Salvador", CountryID = 26, ImageFilename = "salvador.jpg" },
                // new Destination { Id = 52, Name = "Sao Paulo", CountryID = 26, ImageFilename = "sao-paulo.jpg" },
                // new Destination { Id = 53, Name = "Santiago", CountryID = 27, ImageFilename = "santiago.jpg" },
                // new Destination { Id = 54, Name = "Quito", CountryID = 28, ImageFilename = "quito.jpg" },
                // new Destination { Id = 55, Name = "Arequipa", CountryID = 29, ImageFilename = "arequipa.jpg" },
                // new Destination { Id = 77, Name = "Bogota", CountryID = 44, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 78, Name = "Cali", CountryID = 44, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 79, Name = "Caracas", CountryID = 45, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 80, Name = "Maracaibo", CountryID = 45, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 81, Name = "Georgetown", CountryID = 46, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 82, Name = "Annandale, Pomeroon-Supenaam", CountryID = 46, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 83, Name = "Paysandu", CountryID = 47, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 84, Name = "Montevideo", CountryID = 47, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 85, Name = "Oranjestad", CountryID = 48, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 86, Name = "Noord", CountryID = 48, ImageFilename = "no-image.jpg" },
                // // Africa
                // new Destination { Id = 56, Name = "Addis Ababa", CountryID = 30, ImageFilename = "addis-ababa.jpg" },
                // new Destination { Id = 57, Name = "Nairobi", CountryID = 31, ImageFilename = "nairobi.jpg" },
                // new Destination { Id = 58, Name = "Lagos", CountryID = 32, ImageFilename = "lagos.jpg" },
                // new Destination { Id = 59, Name = "Kigali", CountryID = 33, ImageFilename = "kigali.jpg" },
                // new Destination { Id = 60, Name = "Johannesburg", CountryID = 34, ImageFilename = "johannesburg.jpg" },
                // new Destination { Id = 61, Name = "Harare", CountryID = 35, ImageFilename = "harare.jpg" },
                // new Destination { Id = 87, Name = "Antananarivo", CountryID = 49, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 88, Name = "Nosy Be", CountryID = 49, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 89, Name = "Omdurman", CountryID = 50, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 90, Name = "Khartoum", CountryID = 50, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 91, Name = "Juba", CountryID = 51, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 92, Name = "Malakal", CountryID = 51, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 93, Name = "Freetown", CountryID = 52, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 94, Name = "Bo", CountryID = 52, ImageFilename = "no-image.jpg" },
                // // Antarctica
                // new Destination { Id = 62, Name = "McMurdo Station", CountryID = 36, ImageFilename = "mcmurdo-station.jpg" },
                // new Destination { Id = 95, Name = "Antarctic peninsula", CountryID = 36, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 96, Name = "Drake Passage", CountryID = 36, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 97, Name = "Falkland Islands", CountryID = 36, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 98, Name = "King George Island", CountryID = 36, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 99, Name = "Lemaire Channel", CountryID = 36, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 100, Name = "Port Lockroy", CountryID = 36, ImageFilename = "no-image.jpg" },
                // new Destination { Id = 101, Name = "Ross Sea and Ross Ice Shelf", CountryID = 36, ImageFilename = "no-image.jpg" }
            );
        }
    }
}
