using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrganiserTool.Models
{
    [Table("Destination")]
    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public ICollection<Trip> Trips { get; set; }

        public Destination()
        {
            Id = 0;
            Name = string.Empty;
            CountryID = 0;
            Trips = new List<Trip>();
        }
    }

    public class DestinationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public DestinationDTO()
        {
            Id = 0;
            Name = string.Empty;
            CountryID = 0;
            CountryName = string.Empty;
        }
    }
}
