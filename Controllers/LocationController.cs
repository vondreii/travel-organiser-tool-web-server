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
                .Select(c => new RegionDto {
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
                .Select(c => new CountryDto {
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
            .Select(c => new CountryDto {
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
                .Select(l => new DestinationDto {
                    Id = l.Id,
                    Name = l.Name,
                    ImageFilename = l.ImageFilename,
                    CountryID = l.CountryID,
                    CountryName = l.Country.Name,
                    PopulationTypeID = l.PopulationTypeID,
                    PopulationTypeName = l.PopulationType.Name,
                    ClimateTypeID = l.ClimateTypeID,
                    ClimateTypeName = l.ClimateType.Name,
                    TerrainTypeID = l.TerrainTypeID,
                    TerrainTypeName = l.TerrainType.Name})
                .ToListAsync();

            var json = JsonSerializer.Serialize(items);

            return Content(json, "application/json");
        }

        [HttpGet]
        [Route("GetAllDestinations")]
        public async Task<IActionResult> GetAllDestinations()
        {
            var items = await _context.Destinations
                .Select(l => new DestinationDto {
                    Id = l.Id,
                    Name = l.Name,
                    ImageFilename = l.ImageFilename,
                    CountryID = l.CountryID,
                    CountryName = l.Country.Name,
                    PopulationTypeID = l.PopulationTypeID,
                    PopulationTypeName = l.PopulationType.Name,
                    ClimateTypeID = l.ClimateTypeID,
                    ClimateTypeName = l.ClimateType.Name,
                    TerrainTypeID = l.TerrainTypeID,
                    TerrainTypeName = l.TerrainType.Name})
                .ToListAsync();

            var json = JsonSerializer.Serialize(items);

            return Content(json, "application/json");
        }

        [HttpGet]
        [Route("GetFilteredDestinations")]
        public async Task<IActionResult> GetFilteredDestinations(int skip, int take, int populationTypeId, int climateTypeId, int terrainTypeId)
        {
            var filteredDestinations = _context.Destinations.AsQueryable();

            if (populationTypeId != 0)
            {
                filteredDestinations = filteredDestinations.Where(d => d.PopulationTypeID == populationTypeId);
            }
            if (climateTypeId != 0)
            {
                filteredDestinations = filteredDestinations.Where(d => d.ClimateTypeID == climateTypeId);
            }
            if (terrainTypeId != 0)
            {
                filteredDestinations = filteredDestinations.Where(d => d.TerrainTypeID == terrainTypeId);
            }

            var items = await filteredDestinations
            .OrderBy(c => c.Name)
            .Skip(skip)
            .Take(take)
            .Select(d => new DestinationDto
            {
                Id = d.Id,
                Name = d.Name,
                CountryID = d.CountryID,
                CountryName = d.Country.Name,
                PopulationTypeID = d.PopulationTypeID,
                ClimateTypeID = d.ClimateTypeID,
                TerrainTypeID = d.TerrainTypeID,
                ImageFilename = d.ImageFilename
            })
            .ToListAsync();

            var totalCount = await filteredDestinations.CountAsync();

            var json = JsonSerializer.Serialize(new { TotalCount = totalCount, Items = items });

            return Content(json, "application/json");
        }
    }
}