using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrganiserTool.Models
{
    [Table("Country")]
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionID { get; set; }
        public Region Region { get; set; }
        public string ImageFilename { get; set; }
        public ICollection<Destination> Destinations { get; set; }

        public Country()
        {
            Id = 0;
            Name = string.Empty;
            RegionID = 0;
            ImageFilename = string.Empty;
            Destinations = new List<Destination>();
        }
    }

    public class CountryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public string ImageFilename { get; set; }

        public CountryDTO()
        {
            Id = 0;
            Name = string.Empty;
            RegionID = 0;
            RegionName = string.Empty;
            ImageFilename = string.Empty;
        }
    }
}
