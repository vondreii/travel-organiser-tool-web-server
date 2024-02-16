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
        public ICollection<Location> Locations { get; set; }

        public Country()
        {
            Id = 0;
            Name = string.Empty;
            RegionID = 0;
            Locations = new List<Location>();
        }
    }

    public class CountryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionID { get; set; }
        public string RegionName { get; set; }

        public CountryDTO()
        {
            Id = 0;
            Name = string.Empty;
            RegionID = 0;
            RegionName = string.Empty;
        }
    }
}
