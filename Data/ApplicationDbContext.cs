using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Environment;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Data
{
    public class ApplicationDbContext : DbContext
    {
        // TO UPDATE DB CONTEXT:
        // RUN: dotnet ef migrations add initialCreate<newNo>
        // RUN: dotnet ef database update

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Tripstop> Tripstops { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Region> Regions { get; set; } 
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                bool isProduction = EnvironmentService.Instance.IsProduction;

                if (isProduction)
                {
                    optionsBuilder.UseSqlServer("Server=tcp:travel-organiser-tool-server.database.windows.net,1433;Initial Catalog=travel-organiser-tool-sql;Persist Security Info=False;User ID=travel-organiser-tool-admin;Password=hdue_75j728hse5dg7;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                }
                else
                {
                    optionsBuilder.UseSqlServer("Server=DESKTOP-1A7D31U\\SQLEXPRESS;Database=TravelOrganiserTool;Trusted_Connection=True;TrustServerCertificate=True;");
                }
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
            TripstopDbData.Populate(modelBuilder);
            DestinationDbData.Populate(modelBuilder);
            CountryDbData.Populate(modelBuilder);
            RegionDbData.Populate(modelBuilder);

            modelBuilder.Entity<Trip>()
                .HasMany(t => t.Tripstops).WithOne(ts => ts.Trip).HasForeignKey(ts => ts.TripID);

            modelBuilder.Entity<Tripstop>()
                .HasOne(ts => ts.Trip).WithMany(t => t.Tripstops).HasForeignKey(ts => ts.TripID);

            modelBuilder.Entity<Tripstop>()
                .HasOne(ts => ts.Destination).WithMany(l => l.Tripstops).HasForeignKey(ts => ts.DestinationID);

            modelBuilder.Entity<Destination>()
                .HasMany(d => d.Tripstops).WithOne(ts => ts.Destination).HasForeignKey(ts => ts.DestinationID);

            modelBuilder.Entity<Destination>()
                .HasOne(c => c.Country).WithMany(t => t.Destinations).HasForeignKey(c => c.CountryID);

            modelBuilder.Entity<Country>()
                .HasOne(c => c.Region).WithMany(r => r.Countries).HasForeignKey(c => c.RegionID);

            modelBuilder.Entity<Region>()
                .HasMany(r => r.Countries).WithOne(c => c.Region).HasForeignKey(c => c.RegionID);
        }
    }
}
