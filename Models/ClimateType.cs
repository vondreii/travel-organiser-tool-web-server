using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrganiserTool.Models
{
    [Table("ClimateType")]
    public class ClimateType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Destination> Destinations { get; set; }

        public ClimateType()
        {
            Id = 0;
            Name = string.Empty;
            Destinations = new List<Destination>();
        }
    }

    public class ClimateTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ClimateTypeDto()
        {
            Id = 0;
            Name = string.Empty;
        }
    }
}
