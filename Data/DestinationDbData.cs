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
            // CORS is affected for some reason if we read from a text file. Just use this to update the DB.
            var destinations = new List<Destination>();

            // Oceania
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/oceania/australia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/oceania/cook-islands.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/oceania/fiji.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/oceania/kiribati.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/oceania/marshall-islands.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/oceania/micronesia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/oceania/nauru.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/oceania/new-zealand.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/oceania/papua-new-guinea.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/oceania/samoa.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/oceania/solomon-islands.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/oceania/tonga.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/oceania/vanuatu.txt"));

            // South East Asia
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-east-asia/brunei.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-east-asia/burma.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-east-asia/cambodia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-east-asia/indonesia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-east-asia/laos.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-east-asia/malaysia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-east-asia/philippines.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-east-asia/singapore.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-east-asia/thailand.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-east-asia/timor-leste.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-east-asia/vietnam.txt"));

            // East Asia
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/east-asia/china.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/east-asia/hong-kong.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/east-asia/japan.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/east-asia/macao.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/east-asia/mongolia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/east-asia/north-korea.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/east-asia/south-korea.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/east-asia/taiwan.txt"));

            // South Asia
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-asia/afghanistan.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-asia/bangladesh.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-asia/bhutan.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-asia/india.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-asia/maldives.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-asia/nepal.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-asia/pakistan.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-asia/sri-lanka.txt"));

            // Middle East
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/middle-east/bahrain.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/middle-east/iran.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/middle-east/iraq.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/middle-east/israel.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/middle-east/jordan.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/middle-east/kuwait.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/middle-east/lebanon.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/middle-east/oman.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/middle-east/palestine.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/middle-east/qatar.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/middle-east/saudi-arabia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/middle-east/syria.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/middle-east/united-arab-emirates.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/middle-east/yemen.txt"));

            // Scandinavia
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/scandinavia/denmark.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/scandinavia/faroe-islands.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/scandinavia/finland.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/scandinavia/greenland.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/scandinavia/iceland.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/scandinavia/norway.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/scandinavia/sweden.txt"));

            // United Kingdom and Western Europe
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/united-kingdom-and-western-europe/england.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/united-kingdom-and-western-europe/north-ireland.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/united-kingdom-and-western-europe/republic-of-ireland.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/united-kingdom-and-western-europe/scotland.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/united-kingdom-and-western-europe/wales.txt"));

            // Central Europe
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-europe/austria.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-europe/belgium.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-europe/bulgaria.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-europe/czech-republic.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-europe/france.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-europe/germany.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-europe/hungary.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-europe/liechtenstein.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-europe/luxembourg.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-europe/netherlands.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-europe/poland.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-europe/romania.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-europe/serbia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-europe/slovakia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-europe/switzerland.txt"));

            // Southern Europe
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/southern-europe/albania.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/southern-europe/andorra.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/southern-europe/bosnia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/southern-europe/croatia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/southern-europe/cyprus.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/southern-europe/greece.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/southern-europe/italy.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/southern-europe/kosovo.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/southern-europe/malta.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/southern-europe/monaco.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/southern-europe/montenegro.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/southern-europe/north-macedonia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/southern-europe/portugal.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/southern-europe/slovenia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/southern-europe/spain.txt"));

            // Eastern Europe and Former USSR
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/eastern-europe-and-former-ussr/armenia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/eastern-europe-and-former-ussr/azerbaijan.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/eastern-europe-and-former-ussr/belarus.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/eastern-europe-and-former-ussr/estonia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/eastern-europe-and-former-ussr/georgia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/eastern-europe-and-former-ussr/kazakhstan.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/eastern-europe-and-former-ussr/kyrgyzstan.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/eastern-europe-and-former-ussr/latvia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/eastern-europe-and-former-ussr/lithuania.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/eastern-europe-and-former-ussr/moldova.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/eastern-europe-and-former-ussr/russia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/eastern-europe-and-former-ussr/tajikistan.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/eastern-europe-and-former-ussr/turkmenistan.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/eastern-europe-and-former-ussr/ukraine.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/eastern-europe-and-former-ussr/uzbekistan.txt"));

            // Northern Africa
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/northern-africa/algeria.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/northern-africa/egypt.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/northern-africa/libya.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/northern-africa/morocco.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/northern-africa/sudan.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/northern-africa/tunisia.txt"));

            // Subsaharan Africa
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/angola.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/benin.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/botswana.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/burkina-faso.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/burundi.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/cameroon.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/cape-verde.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/central-african-republic.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/chad.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/comoros.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/democratic-republic-of-the-congo.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/djibouti.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/equatorial-guinea.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/eritrea.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/eswatini.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/ethiopia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/gabon.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/gambia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/ghana.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/guinea.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/guinea-bissau.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/ivory-coast.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/kenya.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/lesotho.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/liberia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/madagascar.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/malawi.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/mali.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/mauritania.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/mauritius.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/mozambique.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/namibia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/niger.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/nigeria.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/rwanda.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/sao-tome-and-principe.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/senegal.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/seychelles.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/sierra-leone.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/somalia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/south-africa.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/south-sudan.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/sudan.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/tanzania.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/togo.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/uganda.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/zambia.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/subsaharan-africa/zimbabwe.txt"));

            // North America
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/north-america/canada.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/north-america/mexico.txt"));
            destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/north-america/united-states.txt"));

            // Central America
            // destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/central-america/"));

            // Caribbean
            // destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/caribbean/"));

            // South America
            // destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-america/"));

            // South Pole
            // destinations.AddRange(ReadDestinationsFromFile("Data/DestinationData/south-pole/"));

            modelBuilder.Entity<Destination>().HasData(destinations.ToArray());


            // modelBuilder.Entity<Destination>().HasData(
            //     // // Europe
            //     // new Destination { Id = 24, Name = "Brussels", CountryID = 11, ImageFilename = "brussels.jpg" },
            //     // new Destination { Id = 25, Name = "Bruges", CountryID = 11, ImageFilename = "bruges.jpg" },
            //     // new Destination { Id = 26, Name = "Copenhagen", CountryID = 12, ImageFilename = "copenhagen.jpg" },
            //     // new Destination { Id = 27, Name = "Helsinki", CountryID = 13, ImageFilename = "helsinki.jpg" },
            //     // new Destination { Id = 28, Name = "Paris", CountryID = 14, ImageFilename = "paris.jpg" },
            //     // new Destination { Id = 29, Name = "Berlin", CountryID = 15, ImageFilename = "berlin.jpg" },
            //     // new Destination { Id = 30, Name = "Dublin", CountryID = 16, ImageFilename = "dublin.jpg" },
            //     // new Destination { Id = 31, Name = "Galway", CountryID = 16, ImageFilename = "galway.jpg" },
            //     // new Destination { Id = 32, Name = "Rome", CountryID = 17, ImageFilename = "rome.jpg" },
            //     // new Destination { Id = 33, Name = "Venice", CountryID = 17, ImageFilename = "venice.jpg" },
            //     // new Destination { Id = 34, Name = "Florence", CountryID = 17, ImageFilename = "florence.jpg" },
            //     // new Destination { Id = 35, Name = "Oslo", CountryID = 18, ImageFilename = "oslo.jpg" },
            //     // new Destination { Id = 36, Name = "London", CountryID = 19, ImageFilename = "london.jpg" },
            //     // new Destination { Id = 37, Name = "Bristol", CountryID = 19, ImageFilename = "bristol.jpg" },
            //     // new Destination { Id = 38, Name = "Manchester", CountryID = 19, ImageFilename = "manchester.jpg" },
            //     // new Destination { Id = 39, Name = "Birmingham", CountryID = 19, ImageFilename = "birmingham.jpg" },
            //     // new Destination { Id = 65, Name = "Athens", CountryID = 38, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 66, Name = "Rhodes", CountryID = 38, ImageFilename = "no-image.jpg" },
            //     // // North America
            //     // new Destination { Id = 40, Name = "Nassau", CountryID = 20, ImageFilename = "nassau.jpg" },
            //     // new Destination { Id = 41, Name = "Toronto", CountryID = 21, ImageFilename = "toronto.jpg" },
            //     // new Destination { Id = 42, Name = "Vancouver", CountryID = 21, ImageFilename = "vancouver.jpg" },
            //     // new Destination { Id = 43, Name = "Montego Bay", CountryID = 22, ImageFilename = "montego-bay.jpg" },
            //     // new Destination { Id = 44, Name = "Mexico City", CountryID = 23, ImageFilename = "mexico-city.jpg" },
            //     // new Destination { Id = 45, Name = "Boston", CountryID = 24, ImageFilename = "boston.jpg" },
            //     // new Destination { Id = 46, Name = "Chicago", CountryID = 24, ImageFilename = "chicago.jpg" },
            //     // new Destination { Id = 47, Name = "Los Angeles", CountryID = 24, ImageFilename = "los-angeles.jpg" },
            //     // new Destination { Id = 48, Name = "New York", CountryID = 24, ImageFilename = "new-york.jpg" },
            //     // new Destination { Id = 67, Name = "Havana", CountryID = 39, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 68, Name = "Santa Clara", CountryID = 39, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 69, Name = "Port-au-Prince", CountryID = 40, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 70, Name = "Petion-Ville", CountryID = 40, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 71, Name = "Panama City", CountryID = 41, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 72, Name = "Santiago", CountryID = 41, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 73, Name = "San Jose", CountryID = 42, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 74, Name = "Cartago", CountryID = 42, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 75, Name = "Bridgetown", CountryID = 43, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 76, Name = "Saint James", CountryID = 43, ImageFilename = "no-image.jpg" },
            //     // // South America
            //     // new Destination { Id = 49, Name = "Buenos Aires", CountryID = 25, ImageFilename = "buenos-aires.jpg" },
            //     // new Destination { Id = 50, Name = "Rio de Janeiro", CountryID = 26, ImageFilename = "rio-de-janeiro.jpg" },
            //     // new Destination { Id = 51, Name = "Salvador", CountryID = 26, ImageFilename = "salvador.jpg" },
            //     // new Destination { Id = 52, Name = "Sao Paulo", CountryID = 26, ImageFilename = "sao-paulo.jpg" },
            //     // new Destination { Id = 53, Name = "Santiago", CountryID = 27, ImageFilename = "santiago.jpg" },
            //     // new Destination { Id = 54, Name = "Quito", CountryID = 28, ImageFilename = "quito.jpg" },
            //     // new Destination { Id = 55, Name = "Arequipa", CountryID = 29, ImageFilename = "arequipa.jpg" },
            //     // new Destination { Id = 77, Name = "Bogota", CountryID = 44, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 78, Name = "Cali", CountryID = 44, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 79, Name = "Caracas", CountryID = 45, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 80, Name = "Maracaibo", CountryID = 45, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 81, Name = "Georgetown", CountryID = 46, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 82, Name = "Annandale, Pomeroon-Supenaam", CountryID = 46, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 83, Name = "Paysandu", CountryID = 47, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 84, Name = "Montevideo", CountryID = 47, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 85, Name = "Oranjestad", CountryID = 48, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 86, Name = "Noord", CountryID = 48, ImageFilename = "no-image.jpg" },
            //     // // Africa
            //     // new Destination { Id = 56, Name = "Addis Ababa", CountryID = 30, ImageFilename = "addis-ababa.jpg" },
            //     // new Destination { Id = 57, Name = "Nairobi", CountryID = 31, ImageFilename = "nairobi.jpg" },
            //     // new Destination { Id = 58, Name = "Lagos", CountryID = 32, ImageFilename = "lagos.jpg" },
            //     // new Destination { Id = 59, Name = "Kigali", CountryID = 33, ImageFilename = "kigali.jpg" },
            //     // new Destination { Id = 60, Name = "Johannesburg", CountryID = 34, ImageFilename = "johannesburg.jpg" },
            //     // new Destination { Id = 61, Name = "Harare", CountryID = 35, ImageFilename = "harare.jpg" },
            //     // new Destination { Id = 87, Name = "Antananarivo", CountryID = 49, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 88, Name = "Nosy Be", CountryID = 49, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 89, Name = "Omdurman", CountryID = 50, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 90, Name = "Khartoum", CountryID = 50, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 91, Name = "Juba", CountryID = 51, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 92, Name = "Malakal", CountryID = 51, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 93, Name = "Freetown", CountryID = 52, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 94, Name = "Bo", CountryID = 52, ImageFilename = "no-image.jpg" },
            //     // // Antarctica
            //     // new Destination { Id = 62, Name = "McMurdo Station", CountryID = 36, ImageFilename = "mcmurdo-station.jpg" },
            //     // new Destination { Id = 95, Name = "Antarctic peninsula", CountryID = 36, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 96, Name = "Drake Passage", CountryID = 36, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 97, Name = "Falkland Islands", CountryID = 36, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 98, Name = "King George Island", CountryID = 36, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 99, Name = "Lemaire Channel", CountryID = 36, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 100, Name = "Port Lockroy", CountryID = 36, ImageFilename = "no-image.jpg" },
            //     // new Destination { Id = 101, Name = "Ross Sea and Ross Ice Shelf", CountryID = 36, ImageFilename = "no-image.jpg" }
            // );
        }

        public static List<Destination> ReadDestinationsFromFile(string filePath)
        {
            var destinations = new List<Destination>();

            var lines = File.ReadAllLines(filePath);
            // int id = 1;
            foreach (var line in lines)
            {
                var parts = line.Split(',');

                var destination = new Destination
                {
                    Id = int.Parse(parts[0].Trim()),
                    CountryID = int.Parse(parts[1].Trim()),
                    Name = parts[2].Trim(),
                    ImageFilename = parts[3].Trim(),
                    PopulationTypeID = int.Parse(parts[4].Trim()),
                    ClimateTypeID = int.Parse(parts[5].Trim()),
                    TerrainTypeID = int.Parse(parts[6].Trim())
                };

                destinations.Add(destination);
            }

            return destinations;
        }
    }
}
