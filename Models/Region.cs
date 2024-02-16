using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrganiserTool.Models
{
    [Table("Region")]
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Country> Countries { get; set; }

        public Region()
        {
            Id = 0;
            Name = string.Empty;
            Countries = new List<Country>();
        }
    }

    public class RegionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public RegionDTO()
        {
            Id = 0;
            Name = string.Empty;
        }
    }
}
