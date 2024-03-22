using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
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
            var items = await _context.Regions
                .Select(c => new RegionDTO {
                    Id = c.Id,
                    Name = c.Name})
                .ToListAsync();

            var json = JsonSerializer.Serialize(items);

            return Content(json, "application/json");
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
                    ImageFilename = c.ImageFilename})
                .ToListAsync();

            var json = JsonSerializer.Serialize(items);

            return Content(json, "application/json");
        }

        [HttpGet]
        [Route("GetAllCountries")]
        public async Task<IActionResult> GetAllCountries(int skip, int take)
        {
            var totalCount = await _context.Countries.CountAsync();

            var items = await _context.Countries
            .OrderBy(c => c.Name)
            .Skip(skip)
            .Take(take)
            .Select(c => new CountryDTO {
                Id = c.Id,
                Name = c.Name,
                RegionID = c.RegionID,
                RegionName = c.Region.Name,
                ImageFilename = c.ImageFilename})
            .ToListAsync();

            var json = JsonSerializer.Serialize(new { TotalCount = totalCount, Items = items });

            return Content(json, "application/json");
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
                    CountryName = l.Country.Name, 
                    ImageFilename = l.ImageFilename})
                .ToListAsync();

            var json = JsonSerializer.Serialize(items);

            return Content(json, "application/json");
        }

        [HttpGet]
        [Route("getAllDestinations")]
        public async Task<IActionResult> getAllDestinations()
        {
            var items = await _context.Destinations
                .Select(l => new DestinationDTO {
                    Id = l.Id,
                    Name = l.Name,
                    CountryID = l.CountryID,
                    CountryName = l.Country.Name
                })
                .ToListAsync();

            var json = JsonSerializer.Serialize(items);

            return Content(json, "application/json");
        }
    }
}