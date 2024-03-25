using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrganiserTool.Models
{
    [Table("Destination")]
    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        public string ImageFilename { get; set; }
        public Country Country { get; set; }
        public ICollection<Tripstop> Tripstops { get; set; }

        public Destination()
        {
            Id = 0;
            Name = string.Empty;
            CountryID = 0;
            ImageFilename = string.Empty;
            Tripstops = new List<Tripstop>();
        }
    }

    public class DestinationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string ImageFilename { get; set; }

        public DestinationDto()
        {
            Id = 0;
            Name = string.Empty;
            CountryID = 0;
            CountryName = string.Empty;
            ImageFilename = string.Empty;
        }
    }
}
