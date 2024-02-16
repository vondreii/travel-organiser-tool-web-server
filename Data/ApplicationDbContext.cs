using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TravelOrganiserTool.Data
{
    public class ApplicationDbContext : DbContext
    {
        // to update, run (this is old): 
        // - Add-Migration <name> OR  dotnet ef migrations add initialCreate
        // - Update-Database OR dotnet ef database update
        // Current Migration: InitialCreate4

        // TO UPDATE DB CONTEXT:
        // - OPEN USING VISUAL STUDIO 2022
        // - RUN:dotnet ef migrations add initialCreate<newNo>
        // - RUN:dotnet ef database update
        // - - Microsoft.EntityFrameworkCore.Design - Should be 7.0.11
        // - - Microsoft.EntityFrameworkCore.SqlServer - Should be 7.0.11
        // - - dotnet tools - Should be 7.0.11
        // - - - RUN: dotnet tool update --global dotnet-ef --version 7.0.11

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Region> Regions { get; set; } 
        public DbSet<Country> Countries { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-1A7D31U\\SQLEXPRESS;Database=TravelOrganiserTool;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Once the initial tables/schema are created, this will not run again. 
            // You will have to create a new migration and update the database again.
            // Now that the 'basics' is kind working, connected, should know the structure of the DB first before doing this.
            // And the controllers/services/tables that we will use.
            base.OnModelCreating(modelBuilder);

            // Populate with hard coded seed values, eg, Countries.
            TripDbData.Populate(modelBuilder);
            LocationDbData.Populate(modelBuilder);
            CountryDbData.Populate(modelBuilder);
            RegionDbData.Populate(modelBuilder);

            modelBuilder.Entity<Trip>()
                .HasOne(t => t.Location)
                .WithMany(l => l.Trips)
                .HasForeignKey(t => t.LocationID);

            modelBuilder.Entity<Location>()
                .HasOne(c => c.Country)
                .WithMany(t => t.Locations)
                .HasForeignKey(c => c.CountryID);

            modelBuilder.Entity<Country>()
                .HasOne(c => c.Region)
                .WithMany(r => r.Countries) // Assuming you have a navigation property in the Region class named 'Countries'
                .HasForeignKey(c => c.RegionID);

            modelBuilder.Entity<Region>()
                .HasMany(r => r.Countries)
                .WithOne(c => c.Region)
                .HasForeignKey(c => c.RegionID);
        }
    }
}
