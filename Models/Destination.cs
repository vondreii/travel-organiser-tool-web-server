using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrganiserTool.Models
{
    [Table("Destination")]
    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageFilename { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public int PopulationTypeID { get; set; }
        public PopulationType PopulationType { get; set; }
        public int ClimateTypeID { get; set; }
        public ClimateType ClimateType { get; set; }
        public int TerrainTypeID { get; set; }
        public TerrainType TerrainType { get; set; }
        public ICollection<Tripstop> Tripstops { get; set; }

        public Destination()
        {
            Id = 0;
            Name = string.Empty;
            ImageFilename = string.Empty;
            CountryID = 0;
            PopulationTypeID = 0;
            ClimateTypeID = 0;
            TerrainTypeID = 0;
            Tripstops = new List<Tripstop>();
        }
    }

    public class DestinationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageFilename { get; set; }
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public int PopulationTypeID { get; set; }
        public string PopulationTypeName { get; set; }
        public int ClimateTypeID { get; set; }
        public string ClimateTypeName { get; set; }
        public int TerrainTypeID { get; set; }
        public string TerrainTypeName { get; set; }

        public DestinationDto()
        {
            Id = 0;
            Name = string.Empty;
            ImageFilename = string.Empty;
            CountryID = 0;
            CountryName = string.Empty;
            PopulationTypeID = 0;
            PopulationTypeName = string.Empty;
            ClimateTypeID = 0;
            ClimateTypeName = string.Empty;
            TerrainTypeID = 0;
            TerrainTypeName = string.Empty;
        }
    }
}
