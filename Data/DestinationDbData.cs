using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Models;
using System;
using System.IO;
using System.Linq;
using TravelOrganiserTool.Environment;

namespace TravelOrganiserTool.Data
{
    public static class DestinationDbData
    {
        public static void Populate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Destination>().HasData(
                // Oceania
                new Destination { Id = 1, CountryID = 1, Name = "Adelaide", ImageFilename = "adelaide.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 2, CountryID = 1, Name = "Brisbane", ImageFilename = "brisbane.jpg", PopulationTypeID = 1, ClimateTypeID = 2, TerrainTypeID = 1 },
                new Destination { Id = 3, CountryID = 1, Name = "Canberra", ImageFilename = "canberra.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 4, CountryID = 1, Name = "Hobart", ImageFilename = "hobart.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 5, CountryID = 1, Name = "Melbourne", ImageFilename = "melbourne.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 6, CountryID = 1, Name = "Sydney", ImageFilename = "sydney.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 7, CountryID = 1, Name = "Perth", ImageFilename = "perth.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                // South East Asia
                new Destination { Id = 8, CountryID = 2, Name = "Kuala Lumpur", ImageFilename = "kuala-lumpur.jpg", PopulationTypeID = 1, ClimateTypeID = 2, TerrainTypeID = 1 },
                new Destination { Id = 9, CountryID = 3, Name = "Manila", ImageFilename = "manila.jpg", PopulationTypeID = 1, ClimateTypeID = 2, TerrainTypeID = 1 },
                new Destination { Id = 10, CountryID = 4, Name = "Singapore", ImageFilename = "singapore.jpg", PopulationTypeID = 1, ClimateTypeID = 2, TerrainTypeID = 1 },
                new Destination { Id = 11, CountryID = 5, Name = "Bangkok", ImageFilename = "bangkok.jpg", PopulationTypeID = 1, ClimateTypeID = 2, TerrainTypeID = 1 },
                new Destination { Id = 12, CountryID = 5, Name = "Phuket", ImageFilename = "phuket.jpg", PopulationTypeID = 1, ClimateTypeID = 2, TerrainTypeID = 1 },
                new Destination { Id = 13, CountryID = 6, Name = "Ho Chi Minh City", ImageFilename = "ho-chi-minh-city.jpg", PopulationTypeID = 1, ClimateTypeID = 2, TerrainTypeID = 1 },
                new Destination { Id = 14, CountryID = 6, Name = "Hanoi", ImageFilename = "hanoi.jpg", PopulationTypeID = 1, ClimateTypeID = 2, TerrainTypeID = 1 },
                // East Asia
                new Destination { Id = 15, CountryID = 7, Name = "Beijing", ImageFilename = "beijing.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 16, CountryID = 7, Name = "Shanghai", ImageFilename = "shanghai.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 17, CountryID = 8, Name = "Tokyo", ImageFilename = "tokyo.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 18, CountryID = 8, Name = "Osaka", ImageFilename = "osaka.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 19, CountryID = 8, Name = "Hiroshima", ImageFilename = "hiroshima.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 20, CountryID = 9, Name = "Seoul", ImageFilename = "seoul.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                // South Asia
                new Destination { Id = 21, CountryID = 10, Name = "Mumbai", ImageFilename = "mumbai.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 22, CountryID = 10, Name = "Kolkata", ImageFilename = "kolkata.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 23, CountryID = 10, Name = "Hyderabad", ImageFilename = "hyderabad.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                // Middle East
                new Destination { Id = 24, CountryID = 11, Name = "Kuwait City", ImageFilename = "no-image.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 25, CountryID = 12, Name = "Dubai", ImageFilename = "no-image.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                // Scandinavia
                new Destination { Id = 26, CountryID = 13, Name = "Copenhagen", ImageFilename = "copenhagen.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 27, CountryID = 14, Name = "Helsinki", ImageFilename = "helsinki.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 28, CountryID = 15, Name = "Oslo", ImageFilename = "oslo.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                // United Kingdom and Western Europe
                new Destination { Id = 29, CountryID = 16, Name = "London", ImageFilename = "london.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 30, CountryID = 16, Name = "Bristol", ImageFilename = "bristol.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 31, CountryID = 16, Name = "Manchester", ImageFilename = "manchester.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 32, CountryID = 16, Name = "Birmingham", ImageFilename = "birmingham.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 33, CountryID = 17, Name = "Dublin", ImageFilename = "dublin.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 34, CountryID = 17, Name = "Galway", ImageFilename = "galway.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                // Central Europe
                new Destination { Id = 35, CountryID = 18, Name = "Bruges", ImageFilename = "no-image.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 36, CountryID = 19, Name = "Paris", ImageFilename = "paris.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 37, CountryID = 20, Name = "Berlin", ImageFilename = "berlin.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                // Southern Europe
                new Destination { Id = 38, CountryID = 21, Name = "Rome", ImageFilename = "rome.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 39, CountryID = 21, Name = "Venice", ImageFilename = "venice.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 40, CountryID = 21, Name = "Florence", ImageFilename = "florence.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                // Eastern Europe and Former USSR
                new Destination { Id = 41, CountryID = 22, Name = "Moscow", ImageFilename = "no-image.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                // Northern Africa
                new Destination { Id = 42, CountryID = 23, Name = "Kassala", ImageFilename = "no-image.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                // Subsaharan Africa
                new Destination { Id = 43, CountryID = 24, Name = "Nairobi", ImageFilename = "nairobi.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 44, CountryID = 25, Name = "Kigali", ImageFilename = "kigali.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 45, CountryID = 26, Name = "Johannesburg", ImageFilename = "johannesburg.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                // North America
                new Destination { Id = 46, CountryID = 27, Name = "Toronto", ImageFilename = "toronto.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 47, CountryID = 27, Name = "Vancouver", ImageFilename = "vancouver.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 48, CountryID = 28, Name = "Mexico City", ImageFilename = "mexico-city.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 49, CountryID = 29, Name = "Boston", ImageFilename = "boston.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 50, CountryID = 29, Name = "Chicago", ImageFilename = "chicago.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 51, CountryID = 29, Name = "Los Angeles", ImageFilename = "los-angeles.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 52, CountryID = 29, Name = "New York", ImageFilename = "new-york.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                // Central America
                new Destination { Id = 53, CountryID = 30, Name = "San Jose", ImageFilename = "no-image.jpg", PopulationTypeID = 1, ClimateTypeID = 2, TerrainTypeID = 1 },
                // Caribbean
                new Destination { Id = 54, CountryID = 31, Name = "Montego Bay", ImageFilename = "montego-bay.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                // South America
                new Destination { Id = 55, CountryID = 32, Name = "Rio de Janeiro", ImageFilename = "rio-de-janeiro.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 56, CountryID = 32, Name = "Salvador", ImageFilename = "salvador.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 57, CountryID = 32, Name = "Sao Paulo", ImageFilename = "sao-paulo.jpg", PopulationTypeID = 1, ClimateTypeID = 1, TerrainTypeID = 1 },
                new Destination { Id = 58, CountryID = 33, Name = "Santiago", ImageFilename = "santiago.jpg", PopulationTypeID = 3, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 59, CountryID = 34, Name = "Quito", ImageFilename = "quito.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                new Destination { Id = 60, CountryID = 35, Name = "Arequipa", ImageFilename = "arequipa.jpg", PopulationTypeID = 1, ClimateTypeID = 3, TerrainTypeID = 1 },
                // Antarctica
                new Destination { Id = 61, CountryID = 36, Name = "McMurdo Station", ImageFilename = "mcmurdo-station.jpg", PopulationTypeID = 1, ClimateTypeID = 4, TerrainTypeID = 11 }
            );
        }
    }
}
