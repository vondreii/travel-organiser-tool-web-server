using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrganiserTool.Models
{
    [Table("Location")]
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public ICollection<Trip> Trips { get; set; }

        public Location()
        {
            Id = 0;
            Name = string.Empty;
            CountryID = 0;
            Trips = new List<Trip>();
        }
    }

    public class LocationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public LocationDTO()
        {
            Id = 0;
            Name = string.Empty;
            CountryID = 0;
            CountryName = string.Empty;
        }
    }
}
