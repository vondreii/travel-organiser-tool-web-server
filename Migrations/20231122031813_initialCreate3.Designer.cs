﻿// <auto-generated />
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
    [Migration("20231122031813_initialCreate3")]
    partial class initialCreate3
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
                            Name = "Australia",
                            RegionID = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Japan",
                            RegionID = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "South Korea",
                            RegionID = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Germany",
                            RegionID = 3
                        },
                        new
                        {
                            Id = 5,
                            Name = "France",
                            RegionID = 3
                        },
                        new
                        {
                            Id = 6,
                            Name = "USA",
                            RegionID = 4
                        },
                        new
                        {
                            Id = 7,
                            Name = "Canada",
                            RegionID = 4
                        },
                        new
                        {
                            Id = 8,
                            Name = "Brazil",
                            RegionID = 5
                        },
                        new
                        {
                            Id = 9,
                            Name = "Argentina",
                            RegionID = 5
                        },
                        new
                        {
                            Id = 10,
                            Name = "South Africa",
                            RegionID = 6
                        },
                        new
                        {
                            Id = 11,
                            Name = "Kenya",
                            RegionID = 6
                        });
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("StateOrProvince")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryID");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Sydney",
                            CountryID = 1,
                            StateOrProvince = "NSW"
                        },
                        new
                        {
                            Id = 2,
                            City = "Tokyo",
                            CountryID = 2,
                            StateOrProvince = "Tokyo metropolitan prefecture"
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
                        });
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationID");

                    b.ToTable("Trip");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LocationID = 1,
                            Name = "Visiting Family in Sydney"
                        },
                        new
                        {
                            Id = 2,
                            LocationID = 2,
                            Name = "Visiting Tokyo"
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

            modelBuilder.Entity("TravelOrganiserTool.Models.Location", b =>
                {
                    b.HasOne("TravelOrganiserTool.Models.Country", "Country")
                        .WithMany("Locations")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Trip", b =>
                {
                    b.HasOne("TravelOrganiserTool.Models.Location", "Location")
                        .WithMany("Trips")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Country", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Location", b =>
                {
                    b.Navigation("Trips");
                });

            modelBuilder.Entity("TravelOrganiserTool.Models.Region", b =>
                {
                    b.Navigation("Countries");
                });
#pragma warning restore 612, 618
        }
    }
}