using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrganiserTool.Models
{
    [Table("Trip")]
    public class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Tripstop> Tripstops { get; set; }

        public Trip()
        {
            Id = 0;
            Name = string.Empty;
            CreatedDate = DateTime.Today;
            Tripstops = new List<Tripstop>();
        }
    }

    // DTO = Data Transfer Object
    // For sending the Trip object between back/front end. 
    // Can reduce the payload/what is sent over the request. Only send what is needed.
    // We don't want to send the full Location object and the other references to other objects that are used in the EF/Context
    public class TripDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedDate { get; set; }
        public int NoOfDestinations { get; set; }
        public List<TripstopDto> TripStops { get; set; }


        public TripDto()
        {
            Id = 0;
            Name = string.Empty;
            CreatedDate = DateTime.Today.ToString();
            NoOfDestinations = 0;
            TripStops = new List<TripstopDto>();
        }
    }
}
