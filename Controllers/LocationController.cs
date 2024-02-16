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
                    RegionName = c.Region.Name
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
                RegionName = c.Region.Name
            }).ToListAsync();

            return Ok(items);
        }

        [HttpGet]
        [Route("GetAllLocationsByCountry")]
        public async Task<IActionResult> GetAllLocationsByCountry(int countryID)
        {
            var items = await _context.Locations
                .Where(l => l.CountryID == countryID)
                .Select(l => new LocationDTO {
                    Id = l.Id,
                    Name = l.Name,
                    CountryID = l.CountryID,
                    CountryName = l.Country.Name
                }).ToListAsync();

            return Ok(items);
        }

        [HttpGet]
        [Route("GetAllLocations")]
        public async Task<IActionResult> GetAllLocations()
        {
            var items = await _context.Locations.Select(l => new LocationDTO {
                Id = l.Id,
                Name = l.Name,
                CountryID = l.CountryID,
                CountryName = l.Country.Name
            }).ToListAsync();

            return Ok(items);
        }
    }
}