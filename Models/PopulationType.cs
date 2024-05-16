using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrganiserTool.Models
{
    [Table("PopulationType")]
    public class PopulationType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Destination> Destinations { get; set; }

        public PopulationType()
        {
            Id = 0;
            Name = string.Empty;
            Destinations = new List<Destination>();
        }
    }

    public class PopulationTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PopulationTypeDto()
        {
            Id = 0;
            Name = string.Empty;
        }
    }
}
