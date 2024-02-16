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
                LocationID = t.LocationID,
                LocationName = t.Location.Name,
                CountryID = t.Location.CountryID,
                CountryName = t.Location.Country.Name,
                RegionID = t.Location.Country.RegionID,
                RegionName = t.Location.Country.Region.Name
            }).ToListAsync();

            return Ok(items);
        }

        [HttpGet]
        [Route("GetFilteredTrips")]
        public async Task<IActionResult> GetFilteredTrips(string? name, string? location)
        {
            var filteredTrips = _context.Trips.Include(t => t.Location).AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                filteredTrips = filteredTrips.Where(trip => trip.Name.Contains(name));
            }
            
            if (!string.IsNullOrEmpty(location))
            {
                filteredTrips = filteredTrips.Where(trip => trip.Location.Name.Contains(location));
            }

            var result = await filteredTrips.Select(t => new TripDto {
                Id = t.Id,
                Name = t.Name,
                LocationID = t.LocationID,
                LocationName = t.Location.Name,
                CountryID = t.Location.CountryID,
                CountryName = t.Location.Country.Name,
                RegionID = t.Location.Country.RegionID,
                RegionName = t.Location.Country.Region.Name
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
                LocationID = newTrip.LocationID
            });

            _context.SaveChanges();
            return Ok();
        }
    }
}