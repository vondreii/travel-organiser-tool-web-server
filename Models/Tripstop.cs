using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrganiserTool.Models
{
    [Table("Tripstop")]
    public class Tripstop
    {
        public int Id { get; set; }
        public int TripID { get; set; }
        public int DestinationID { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public Trip Trip { get; set; }
        public Destination Destination { get; set; }

        public Tripstop()
        {
            Id = 0;
            TripID = 0;
            DestinationID = 0;
            Startdate = DateTime.Today;
            Enddate = DateTime.Today;
        }
    }

    // DTO = Data Transfer Object
    // For sending the Trip object between back/front end. 
    // Can reduce the payload/what is sent over the request. Only send what is needed.
    // We don't want to send the full Location object and the other references to other objects that are used in the EF/Context
    public class TripstopDto
    {
        public int Id { get; set; }
        public int TripID { get; set; }
        public string Startdate { get; set; }
        public string Enddate { get; set; }
        public int DestinationID { get; set; }
        public string DestinationName { get; set; }
        public string DestinationImageFileName { get; set; }
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public int RegionID { get; set; }
        public string RegionName { get; set; }

        public TripstopDto()
        {
            Id = 0;
            TripID = 0;
            Startdate = DateTime.Today.ToString();
            Enddate = DateTime.Today.ToString();
            DestinationID = 0;
            DestinationName = string.Empty;
            DestinationImageFileName = string.Empty;
            CountryID = 0;
            CountryName = string.Empty;
            RegionID = 0;
            RegionName = string.Empty;
        }
    }
}
