using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Data;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TripController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TripController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetAllTrips")]
        public async Task<IActionResult> GetAllTrips()
        {
            var items = await _context.Trips.Select(t => new TripDto {
                Id = t.Id,
                Name = t.Name,
                DestinationID = t.DestinationID,
                DestinationName = t.Destination.Name,
                CountryID = t.Destination.CountryID,
                CountryName = t.Destination.Country.Name,
                RegionID = t.Destination.Country.RegionID,
                RegionName = t.Destination.Country.Region.Name
            }).ToListAsync();

            return Ok(items);
        }

        [HttpGet]
        [Route("GetFilteredTrips")]
        public async Task<IActionResult> GetFilteredTrips(string? name, string? destination)
        {
            var filteredTrips = _context.Trips.Include(t => t.Destination).AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                filteredTrips = filteredTrips.Where(trip => trip.Name.Contains(name));
            }
            
            if (!string.IsNullOrEmpty(destination))
            {
                filteredTrips = filteredTrips.Where(trip => trip.Destination.Name.Contains(destination));
            }

            var result = await filteredTrips.Select(t => new TripDto {
                Id = t.Id,
                Name = t.Name,
                DestinationID = t.DestinationID,
                DestinationName = t.Destination.Name,
                CountryID = t.Destination.CountryID,
                CountryName = t.Destination.Country.Name,
                RegionID = t.Destination.Country.RegionID,
                RegionName = t.Destination.Country.Region.Name
            }).ToListAsync();

            return Ok(result);
        }

        [HttpPost]
        [Route("Post")]
        public IActionResult Post([FromBody] TripDto newTrip)
        {
            _context.Trips.Add(new Trip() {
                Id = newTrip.Id,
                Name = newTrip.Name,
                DestinationID = newTrip.DestinationID
            });

            _context.SaveChanges();
            return Ok();
        }
    }
}