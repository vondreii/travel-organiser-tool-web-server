using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrganiserTool.Models
{
    [Table("TerrainType")]
    public class TerrainType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Destination> Destinations { get; set; }

        public TerrainType()
        {
            Id = 0;
            Name = string.Empty;
            Destinations = new List<Destination>();
        }
    }

    public class TerrainTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TerrainTypeDto()
        {
            Id = 0;
            Name = string.Empty;
        }
    }
}
