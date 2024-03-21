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
            var items = await _context.Trips
                .Select(t => new TripDto {
                    Id = t.Id,
                    Name = t.Name})
                .ToListAsync();

            return Ok(items);
        }

        [HttpGet]
        [Route("GetAllTripstops")]
        public async Task<IActionResult> GetAllTripstops(int tripId)
        {
            var items = await _context.Tripstops
                .Select(t => new TripstopDto {
                    Id = t.Id,
                    TripID = t.TripID,
                    TripName = t.Trip.Name,
                    DestinationID = t.DestinationID,
                    DestinationName = t.Destination.Name,
                    CountryID = t.Destination.CountryID,
                    CountryName = t.Destination.Country.Name,
                    RegionID = t.Destination.Country.RegionID,
                    RegionName = t.Destination.Country.Region.Name})
                .Where(t => t.TripID == tripId)
                .ToListAsync();
        
            return Ok(items);
        }

        [HttpGet]
        [Route("GetFilteredTrips")]
        public async Task<IActionResult> GetFilteredTrips(int? id, string? name)
        {
            var filteredTrips = _context.Trips.AsQueryable();

            if (id != null)
            {
                filteredTrips = filteredTrips.Where(trip => trip.Id == id);
            }
            if (!string.IsNullOrEmpty(name))
            {
                filteredTrips = filteredTrips.Where(trip => trip.Name.Contains(name));
            }
        
            var result = await filteredTrips
                .Select(t => new TripDto {
                    Id = t.Id,
                    Name = t.Name})
                .ToListAsync();
        
            return Ok(result);
        }

        [HttpPost]
        [Route("Post")]
        public IActionResult Post([FromBody] TripDto newTrip)
        {
            _context.Trips.Add(new Trip() {
                Id = newTrip.Id,
                Name = newTrip.Name
            });
        
            _context.SaveChanges();
            return Ok();
        }
    }
}