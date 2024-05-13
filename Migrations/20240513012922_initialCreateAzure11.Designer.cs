﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelOrganiserTool.Data;

#nullable disable

namespace TravelOrganiserTool.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240513012922_initialCreateAzure11")]
    partial class initialCreateAzure11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TravelOrganiserTool.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageFilename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegionID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionID");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageFilename = "australia.jpg",
                            Name = "Australia",
                            RegionID = 1
                        },
                        new
                        {
                            Id = 2,
                            ImageFilename = "china.jpg",
                            Name = "China",
                            RegionID = 2
                        },
                        new
                        {
                            Id = 3,
                            ImageFilename = "india.jpg",
                            Name = "India",
                            RegionID = 2
                        },
                        new
                        {
                            Id = 4,
                            ImageFilename = "japan.jpg",
                            Name = "Japan",
                            RegionID = 2
                        },
                        new
                        {
                            Id = 5,
                            ImageFilename = "malaysia.jpg",
                            Name = "Malaysia",
                            RegionID = 2
                        },
                        new
                        {
                            Id = 6,
                            ImageFilename = "philippines.jpg",
                            Name = "Philippines",
                            RegionID = 2
                        },
                        new
                        {
                            Id = 7,
                            ImageFilename = "singapore.jpg",
                            Name = "Singapore",
                            RegionID = 2
                        },
                        new
                        {
                            Id = 8,
                            ImageFilename = "south-korea.jpg",
                            Name = "South Korea",
                            RegionID = 2
                        },
                        new
                        {
                            Id = 9,
                            ImageFilename = "thailand.jpg",
                            Name = "Thailand",
                            RegionID = 2
                        },
                        new
                        {
                            Id = 10,
                            ImageFilename = "vietnam.jpg",
                            Name = "Vietnam",
                            RegionID = 2
                        },
                        new
                        {
                            Id = 11,
                            ImageFilename = "no-image.jpg",
                            Name = "Belgium",
                            RegionID = 3
                        },
                        new
                        {
                            Id = 12,
                            ImageFilename = "no-image.jpg",
                            Name = "Denmark",
                            RegionID = 3
                        },
                        new
                        {
                            Id = 13,
                            ImageFilename = "no-image.jpg",
                            Name = "Finland",
                            RegionID = 3
                        },
                        new
                        {
                            Id = 14,
                            ImageFilename = "no-image.jpg",
                            Name = "France",
                            RegionID = 3
                        },
                        new
                        {
                            Id = 15,
                            ImageFilename = "no-image.jpg",
                            Name = "Germany",
                            RegionID = 3
                        },
                        new
                        {
                            Id = 16,
                            ImageFilename = "no-image.jpg",
                            Name = "Ireland",
                            RegionID = 3
                        },
                        new
                        {
                            Id = 17,
                            ImageFilename = "no-image.jpg",
                            Name = "Italy",
                            RegionID = 3
                        },
                        new
                        {
                            Id = 18,
                            ImageFilename = "no-image.jpg",
                            Name = "Norway",
                            RegionID = 3
                        },
                        new
                        {
                            Id = 19,
                            ImageFilename = "no-image.jpg",
                            Name = "United Kingdom",
                            RegionID = 3
                        },
                        new
                        {
                            Id = 20,
                            ImageFilename = "no-image.jpg",
                            Name = "Bahamas",
                            RegionID = 4
                        },
                        new
                        {
                            Id = 21,
                            ImageFilename = "no-image.jpg",
                            Name = "Canada",
                            RegionID = 4
                        },
                        new
                        {
                            Id = 22,
                            ImageFilename = "no-image.jpg",
                            Name = "Jamaica",
                            RegionID = 4
                        },
                        new
                        {
                            Id = 23,
                            ImageFilename = "no-image.jpg",
                            Name = "Mexico",
                            RegionID = 4
                        },
                        new
                        {
                            Id = 24,
                            ImageFilename = "no-image.jpg",
                            Name = "United States",
                            RegionID = 4
                        },
                        new
                        {
                            Id = 25,
                            ImageFilename = "no-image.jpg",
                            Name = "Argentina",
                            RegionID = 5
                        },
                        new
                        {
                            Id = 26,
                            ImageFilename = "no-image.jpg",
                            Name = "Brazil",
                            RegionID = 5
                        },
                        new
                        {
                            Id = 27,
                            ImageFilename = "no-image.jpg",
                            Name = "Chile",
                            RegionID = 5
                        },
                        new
                        {
                            Id = 28,
                            ImageFilename = "no-image.jpg",
                            Name = "Ecuador",
                            RegionID = 5
                        },
                        new
                        {
                            Id = 29,
                            ImageFilename = "no-image.jpg",
                            Name = "Peru",
                            RegionID = 5
                        },
                        new
                        {
                            Id = 30,
                            ImageFilename = "no-image.jpg",
                            Name = "Ethiopia",
                            RegionID = 6
                        },
                        new
                        {
                            Id = 31,
                            ImageFilename = "no-image.jpg",
                            Name = "Kenya",
                            RegionID = 6
                        },
                        new
                        {
                            Id = 32,
                            ImageFilename = "no-image.jpg",
                            Name = "Nigeria",
                            RegionID = 6
                        },
                        new
                        {
                            Id = 33,
                            ImageFilename = "no-image.jpg",
                            Name = "Rwanda",
                            RegionID = 6
                        },
                        new
                        {
                            Id = 34,
                            ImageFilename = "no-image.jpg",
                            Name = "South Africa",
                            RegionID = 6
                        },
                        new
                        {
                            Id = 35,
                            ImageFilename = "no-image.jpg",
                            Name = "Zimbabwe",
                            RegionID = 6
                        },
                        new
                        {
                            Id = 36,
                            ImageFilename = "no-image.jpg",
                            Name = "Antarctica",
                            RegionID = 7
                        });
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("ImageFilename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryID");

                    b.ToTable("Destination");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryID = 1,
                            ImageFilename = "adelaide.jpg",
                            Name = "Adelaide"
                        },
                        new
                        {
                            Id = 2,
                            CountryID = 1,
                            ImageFilename = "brisbane.jpg",
                            Name = "Brisbane"
                        },
                        new
                        {
                            Id = 3,
                            CountryID = 1,
                            ImageFilename = "canberra.jpg",
                            Name = "Canberra"
                        },
                        new
                        {
                            Id = 4,
                            CountryID = 1,
                            ImageFilename = "hobart.jpg",
                            Name = "Hobart"
                        },
                        new
                        {
                            Id = 5,
                            CountryID = 1,
                            ImageFilename = "melbourne.jpg",
                            Name = "Melbourne"
                        },
                        new
                        {
                            Id = 6,
                            CountryID = 1,
                            ImageFilename = "sydney.jpg",
                            Name = "Sydney"
                        },
                        new
                        {
                            Id = 7,
                            CountryID = 1,
                            ImageFilename = "perth.jpg",
                            Name = "Perth"
                        },
                        new
                        {
                            Id = 8,
                            CountryID = 2,
                            ImageFilename = "beijing.jpg",
                            Name = "Beijing"
                        },
                        new
                        {
                            Id = 9,
                            CountryID = 2,
                            ImageFilename = "shanghai.jpg",
                            Name = "Shanghai"
                        },
                        new
                        {
                            Id = 10,
                            CountryID = 3,
                            ImageFilename = "mumbai.jpg",
                            Name = "Mumbai"
                        },
                        new
                        {
                            Id = 11,
                            CountryID = 3,
                            ImageFilename = "kolkata.jpg",
                            Name = "Kolkata"
                        },
                        new
                        {
                            Id = 12,
                            CountryID = 3,
                            ImageFilename = "hyderabad.jpg",
                            Name = "Hyderabad"
                        },
                        new
                        {
                            Id = 13,
                            CountryID = 4,
                            ImageFilename = "no-image.jpg",
                            Name = "Tokyo"
                        },
                        new
                        {
                            Id = 14,
                            CountryID = 4,
                            ImageFilename = "osaka.jpg",
                            Name = "Osaka"
                        },
                        new
                        {
                            Id = 15,
                            CountryID = 4,
                            ImageFilename = "hiroshima.jpg",
                            Name = "Hiroshima"
                        },
                        new
                        {
                            Id = 16,
                            CountryID = 5,
                            ImageFilename = "kuala-lumpur.jpg",
                            Name = "Kuala Lumpur"
                        },
                        new
                        {
                            Id = 17,
                            CountryID = 6,
                            ImageFilename = "manila.jpg",
                            Name = "Manila"
                        },
                        new
                        {
                            Id = 18,
                            CountryID = 7,
                            ImageFilename = "singapore.jpg",
                            Name = "Singapore"
                        },
                        new
                        {
                            Id = 19,
                            CountryID = 8,
                            ImageFilename = "seoul.jpg",
                            Name = "Seoul"
                        },
                        new
                        {
                            Id = 20,
                            CountryID = 9,
                            ImageFilename = "bangkok.jpg",
                            Name = "Bangkok"
                        },
                        new
                        {
                            Id = 21,
                            CountryID = 9,
                            ImageFilename = "phuket.jpg",
                            Name = "Phuket"
                        },
                        new
                        {
                            Id = 22,
                            CountryID = 10,
                            ImageFilename = "ho-chi-minh-city.jpg",
                            Name = "Ho Chi Minh City"
                        },
                        new
                        {
                            Id = 23,
                            CountryID = 10,
                            ImageFilename = "hanoi.jpg",
                            Name = "Hanoi"
                        },
                        new
                        {
                            Id = 24,
                            CountryID = 11,
                            ImageFilename = "brussels.jpg",
                            Name = "Brussels"
                        },
                        new
                        {
                            Id = 25,
                            CountryID = 11,
                            ImageFilename = "bruges.jpg",
                            Name = "Bruges"
                        },
                        new
                        {
                            Id = 26,
                            CountryID = 12,
                            ImageFilename = "copenhagen.jpg",
                            Name = "Copenhagen"
                        },
                        new
                        {
                            Id = 27,
                            CountryID = 13,
                            ImageFilename = "helsinki.jpg",
                            Name = "Helsinki"
                        },
                        new
                        {
                            Id = 28,
                            CountryID = 14,
                            ImageFilename = "paris.jpg",
                            Name = "Paris"
                        },
                        new
                        {
                            Id = 29,
                            CountryID = 15,
                            ImageFilename = "berlin.jpg",
                            Name = "Berlin"
                        },
                        new
                        {
                            Id = 30,
                            CountryID = 16,
                            ImageFilename = "dublin.jpg",
                            Name = "Dublin"
                        },
                        new
                        {
                            Id = 31,
                            CountryID = 16,
                            ImageFilename = "galway.jpg",
                            Name = "Galway"
                        },
                        new
                        {
                            Id = 32,
                            CountryID = 17,
                            ImageFilename = "rome.jpg",
                            Name = "Rome"
                        },
                        new
                        {
                            Id = 33,
                            CountryID = 17,
                            ImageFilename = "venice.jpg",
                            Name = "Venice"
                        },
                        new
                        {
                            Id = 34,
                            CountryID = 17,
                            ImageFilename = "florence.jpg",
                            Name = "Florence"
                        },
                        new
                        {
                            Id = 35,
                            CountryID = 18,
                            ImageFilename = "no-image.jpg",
                            Name = "Oslo"
                        },
                        new
                        {
                            Id = 36,
                            CountryID = 19,
                            ImageFilename = "no-image.jpg",
                            Name = "London"
                        },
                        new
                        {
                            Id = 37,
                            CountryID = 19,
                            ImageFilename = "no-image.jpg",
                            Name = "Bristol"
                        },
                        new
                        {
                            Id = 38,
                            CountryID = 19,
                            ImageFilename = "no-image.jpg",
                            Name = "Manchester"
                        },
                        new
                        {
                            Id = 39,
                            CountryID = 19,
                            ImageFilename = "no-image.jpg",
                            Name = "Birmingham"
                        },
                        new
                        {
                            Id = 40,
                            CountryID = 20,
                            ImageFilename = "no-image.jpg",
                            Name = "Nassau"
                        },
                        new
                        {
                            Id = 41,
                            CountryID = 21,
                            ImageFilename = "no-image.jpg",
                            Name = "Toronto"
                        },
                        new
                        {
                            Id = 42,
                            CountryID = 21,
                            ImageFilename = "no-image.jpg",
                            Name = "Vancouver"
                        },
                        new
                        {
                            Id = 43,
                            CountryID = 22,
                            ImageFilename = "no-image.jpg",
                            Name = "Montego Bay"
                        },
                        new
                        {
                            Id = 44,
                            CountryID = 23,
                            ImageFilename = "no-image.jpg",
                            Name = "Mexico City"
                        },
                        new
                        {
                            Id = 45,
                            CountryID = 24,
                            ImageFilename = "no-image.jpg",
                            Name = "Boston"
                        },
                        new
                        {
                            Id = 46,
                            CountryID = 24,
                            ImageFilename = "no-image.jpg",
                            Name = "Chicago"
                        },
                        new
                        {
                            Id = 47,
                            CountryID = 24,
                            ImageFilename = "no-image.jpg",
                            Name = "Los Angeles"
                        },
                        new
                        {
                            Id = 48,
                            CountryID = 24,
                            ImageFilename = "no-image.jpg",
                            Name = "New York"
                        },
                        new
                        {
                            Id = 49,
                            CountryID = 25,
                            ImageFilename = "no-image.jpg",
                            Name = "Buenos Aires"
                        },
                        new
                        {
                            Id = 50,
                            CountryID = 26,
                            ImageFilename = "no-image.jpg",
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = 51,
                            CountryID = 26,
                            ImageFilename = "no-image.jpg",
                            Name = "Salvador"
                        },
                        new
                        {
                            Id = 52,
                            CountryID = 26,
                            ImageFilename = "no-image.jpg",
                            Name = "Sao Paulo"
                        },
                        new
                        {
                            Id = 53,
                            CountryID = 27,
                            ImageFilename = "no-image.jpg",
                            Name = "Santiago"
                        },
                        new
                        {
                            Id = 54,
                            CountryID = 28,
                            ImageFilename = "no-image.jpg",
                            Name = "Quito"
                        },
                        new
                        {
                            Id = 55,
                            CountryID = 29,
                            ImageFilename = "no-image.jpg",
                            Name = "Arequipa"
                        },
                        new
                        {
                            Id = 56,
                            CountryID = 30,
                            ImageFilename = "no-image.jpg",
                            Name = "Addis Ababa"
                        },
                        new
                        {
                            Id = 57,
                            CountryID = 31,
                            ImageFilename = "no-image.jpg",
                            Name = "Nairobi"
                        },
                        new
                        {
                            Id = 58,
                            CountryID = 32,
                            ImageFilename = "no-image.jpg",
                            Name = "Lagos"
                        },
                        new
                        {
                            Id = 59,
                            CountryID = 33,
                            ImageFilename = "no-image.jpg",
                            Name = "Kigali"
                        },
                        new
                        {
                            Id = 60,
                            CountryID = 34,
                            ImageFilename = "no-image.jpg",
                            Name = "Johannesburg"
                        },
                        new
                        {
                            Id = 61,
                            CountryID = 35,
                            ImageFilename = "no-image.jpg",
                            Name = "Harare"
                        },
                        new
                        {
                            Id = 62,
                            CountryID = 36,
                            ImageFilename = "mcmurdo-station.jpg",
                            Name = "McMurdo Station"
                        });
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Region");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Australia"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Asia"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Europe"
                        },
                        new
                        {
                            Id = 4,
                            Name = "North America"
                        },
                        new
                        {
                            Id = 5,
                            Name = "South America"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Africa"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Antarctica"
                        });
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trip");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Example Trip: Visiting Family in Sydney"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Example Trip: Visiting Tokyo"
                        });
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Tripstop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DestinationID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Enddate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Startdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TripID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DestinationID");

                    b.HasIndex("TripID");

                    b.ToTable("Tripstop");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DestinationID = 6,
                            Enddate = new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Startdate = new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            TripID = 1
                        },
                        new
                        {
                            Id = 2,
                            DestinationID = 5,
                            Enddate = new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Startdate = new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            TripID = 1
                        },
                        new
                        {
                            Id = 3,
                            DestinationID = 13,
                            Enddate = new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Startdate = new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            TripID = 2
                        },
                        new
                        {
                            Id = 4,
                            DestinationID = 19,
                            Enddate = new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Startdate = new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            TripID = 2
                        });
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Country", b =>
                {
                    b.HasOne("TravelOrganiserTool.Models.Region", "Region")
                        .WithMany("Countries")
                        .HasForeignKey("RegionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Destination", b =>
                {
                    b.HasOne("TravelOrganiserTool.Models.Country", "Country")
                        .WithMany("Destinations")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Tripstop", b =>
                {
                    b.HasOne("TravelOrganiserTool.Models.Destination", "Destination")
                        .WithMany("Tripstops")
                        .HasForeignKey("DestinationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelOrganiserTool.Models.Trip", "Trip")
                        .WithMany("Tripstops")
                        .HasForeignKey("TripID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destination");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Country", b =>
                {
                    b.Navigation("Destinations");
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Destination", b =>
                {
                    b.Navigation("Tripstops");
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Region", b =>
                {
                    b.Navigation("Countries");
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Trip", b =>
                {
                    b.Navigation("Tripstops");
                });
#pragma warning restore 612, 618
        }
    }
}
