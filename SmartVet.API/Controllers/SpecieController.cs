using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.DTOs.Specie;
using SmartVet.Application.Interfaces;
using SmartVet.Application.Services;

namespace SmartVet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecieController : ControllerBase
    {
        private readonly ISpecieService _specieService;

        public SpecieController(ISpecieService specieService)
        {
            _specieService = specieService;
        }

        [HttpGet("GetSpecieById")]
        public async Task<SpecieDTO> GetSpecieById(int id)
        {
            return await _specieService.GetById(id);
        }

        [HttpGet("GetSpecies")]
        public async Task<IEnumerable<SpecieDTO>> GetSpecies()
        {
            return await _specieService.GetAll();
        }

        [HttpPost("AddSpecie")]
        public async Task AddSpecie(SpecieDTO specie)
        {
            await _specieService.Add(specie);
        }

        [HttpPut("UpdateSpecie")]
        public async Task UpdateSpecie(SpecieDTO specie)
        {
            await _specieService.Update(specie);
        }

        [HttpDelete("RemoveSpecie")]
        public async Task RemoveSpecie(int id)
        {
            await _specieService.Remove(id);
        }
    }
}
