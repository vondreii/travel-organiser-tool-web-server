using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Data;
using TravelOrganiserTool.Models;
using System.Text.Json;

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
                    Name = t.Name,
                    CreatedDate = t.CreatedDate.ToString(),
                    NoOfDestinations = t.Tripstops.Count(x => x.TripID == t.Id),
                    TripStops = t.Tripstops.Select(ts => new TripstopDto {
                        Id = ts.Id,
                        TripID = ts.TripID,
                        Startdate = ts.Startdate.ToString(),
                        Enddate = ts.Enddate.ToString(),
                        DestinationID = ts.DestinationID,
                        DestinationName = ts.Destination.Name,
                        DestinationImageFileName = ts.Destination.ImageFilename,
                        CountryID = ts.Destination.CountryID,
                        CountryName = ts.Destination.Country.Name,
                        RegionID = ts.Destination.Country.RegionID,
                        RegionName = ts.Destination.Country.Region.Name
                    }).ToList()
                })
                .ToListAsync();

            var json = JsonSerializer.Serialize(items);

            return Content(json, "application/json");
        }

        [HttpGet]
        [Route("GetAllTripstops")]
        public async Task<IActionResult> GetAllTripstops(int tripId)
        {
            var items = await _context.Tripstops
                .Select(t => new TripstopDto {
                    Id = t.Id,
                    TripID = t.TripID,
                    Startdate = t.Startdate.ToString(),
                    Enddate = t.Enddate.ToString(),
                    DestinationID = t.DestinationID,
                    DestinationName = t.Destination.Name,
                    DestinationImageFileName = t.Destination.ImageFilename,
                    CountryID = t.Destination.CountryID,
                    CountryName = t.Destination.Country.Name,
                    RegionID = t.Destination.Country.RegionID,
                    RegionName = t.Destination.Country.Region.Name})
                .Where(t => t.TripID == tripId)
                .ToListAsync();

            var json = JsonSerializer.Serialize(items);

            return Content(json, "application/json");
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
                    Name = t.Name,
                    CreatedDate = t.CreatedDate.ToString(),
                    NoOfDestinations = t.Tripstops.Count(x => x.TripID == t.Id),
                    TripStops = t.Tripstops.Select(ts => new TripstopDto
                    {
                        Id = ts.Id,
                        TripID = ts.TripID,
                        Startdate = ts.Startdate.ToString(),
                        Enddate = ts.Enddate.ToString(),
                        DestinationID = ts.DestinationID,
                        DestinationName = ts.Destination.Name,
                        DestinationImageFileName = ts.Destination.ImageFilename,
                        CountryID = ts.Destination.CountryID,
                        CountryName = ts.Destination.Country.Name,
                        RegionID = ts.Destination.Country.RegionID,
                        RegionName = ts.Destination.Country.Region.Name
                    }).ToList()
                })
                .ToListAsync();

            var json = JsonSerializer.Serialize(result);

            return Content(json, "application/json"); ;
        }

        [HttpPost]
        [Route("Post")]
        public IActionResult Post([FromBody] TripDto newTrip)
        {
            _context.Trips.Add(new Trip() {
                Id = newTrip.Id,
                Name = newTrip.Name,
                CreatedDate = DateTime.UtcNow
            });
        
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        [Route("AddTripStop")]
        public IActionResult AddTripStop([FromBody] TripstopDto newTripstop)
        {
            _context.Tripstops.Add(new Tripstop()
            {
                Id = newTripstop.Id,
                TripID = newTripstop.TripID,
                DestinationID = newTripstop.DestinationID,
                Startdate = DateTime.Parse(newTripstop.Startdate),
                Enddate = DateTime.Parse(newTripstop.Enddate),
            });

            _context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        [Route("EditTrip")]
        public IActionResult EditTrip([FromBody] TripDto editedTrip)
        {
            var trip = _context.Trips
                .SingleOrDefault(t => t.Id == editedTrip.Id);

            if (trip != null)
            {
                trip.Name = editedTrip.Name;
                trip.CreatedDate = DateTime.Parse(editedTrip.CreatedDate);
                _context.Entry(trip).State = EntityState.Modified;
            }

            _context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        [Route("DeleteTrip")]
        public IActionResult DeleteTrip([FromBody] TripDto deletedTrip)
        {
            var trip = _context.Trips
                .SingleOrDefault(t => t.Id == deletedTrip.Id);

            if (trip != null)
            {
                _context.Trips.Remove(trip);
            }

            _context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        [Route("EditTripstop")]
        public IActionResult EditTripstop([FromBody] TripstopDto editedTripstop)
        {
            var tripstop = _context.Tripstops
                .SingleOrDefault(t => t.Id == editedTripstop.Id);

            if (tripstop != null)
            {
                tripstop.Startdate = DateTime.Parse(editedTripstop.Startdate);
                tripstop.Enddate = DateTime.Parse(editedTripstop.Enddate);
                tripstop.DestinationID = editedTripstop.DestinationID;
                tripstop.Destination = _context.Destinations.Single(d => d.Id == editedTripstop.DestinationID);

                _context.Entry(tripstop).State = EntityState.Modified;
            }

            _context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        [Route("DeleteTripstop")]
        public IActionResult DeleteTripstop([FromBody] TripstopDto deleteTripstop)
        {
            var tripstop = _context.Tripstops
                .SingleOrDefault(t => t.Id == deleteTripstop.Id);

            if (tripstop != null)
            {
                _context.Tripstops.Remove(tripstop);
            }

            _context.SaveChanges();
            return Ok();
        }
    }
}