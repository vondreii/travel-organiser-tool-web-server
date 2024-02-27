using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelOrganiserTool.Data;
using TravelOrganiserTool.Models;

namespace TravelOrganiserTool.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LocationController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetAllRegions")]
        public async Task<IActionResult> GetAllRegions()
        {
            var items = await _context.Regions.Select(c => new RegionDTO {
                Id = c.Id,
                Name = c.Name
            }).ToListAsync();

            return Ok(items);
        }

        [HttpGet]
        [Route("GetAllCountriesByRegion")]
        public async Task<IActionResult> GetAllCountriesByRegion(int regionID)
        {
            var items = await _context.Countries
                .Where(c => c.RegionID == regionID)
                .Select(c => new CountryDTO {
                    Id = c.Id,
                    Name = c.Name,
                    RegionID = c.RegionID,
                    RegionName = c.Region.Name,
                    ImageFilename = c.ImageFilename
                }).ToListAsync();

            return Ok(items);
        }

        [HttpGet]
        [Route("GetAllCountries")]
        public async Task<IActionResult> GetAllCountries()
        {
            var items = await _context.Countries.Select(c => new CountryDTO {
                Id = c.Id,
                Name = c.Name,
                RegionID = c.RegionID,
                RegionName = c.Region.Name,
                ImageFilename = c.ImageFilename
            }).ToListAsync();

            return Ok(items);
        }

        [HttpGet]
        [Route("GetAllDestinationsByCountry")]
        public async Task<IActionResult> GetAllDestinationsByCountry(int countryID)
        {
            var items = await _context.Destinations
                .Where(l => l.CountryID == countryID)
                .Select(l => new DestinationDTO {
                    Id = l.Id,
                    Name = l.Name,
                    CountryID = l.CountryID,
                    CountryName = l.Country.Name
                }).ToListAsync();

            return Ok(items);
        }

        [HttpGet]
        [Route("getAllDestinations")]
        public async Task<IActionResult> getAllDestinations()
        {
            var items = await _context.Destinations.Select(l => new DestinationDTO
            {
                Id = l.Id,
                Name = l.Name,
                CountryID = l.CountryID,
                CountryName = l.Country.Name
            }).ToListAsync();

            return Ok(items);
        }
    }
}