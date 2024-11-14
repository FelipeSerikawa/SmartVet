using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.DTOs.Specie;
using SmartVet.Application.Interfaces;

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
        public async Task<IActionResult> GetSpecieById(int id)
        {
            var specie = await _specieService.GetById(id);
            return Ok(specie);
        }

        [HttpGet("GetSpecies")]
        public async Task<IActionResult> GetSpecies()
        {
            var species = await _specieService.GetAll();
            return Ok(species);
        }

        [HttpPost("AddSpecie")]
        public async Task<IActionResult> AddSpecie(SpecieCreateDTO specie)
        {
            await _specieService.Add(specie);
            return Ok();
        }

        [HttpPut("UpdateSpecie")]
        public async Task<IActionResult> UpdateSpecie(SpecieUpdateDTO specie)
        {
            await _specieService.Update(specie);
            return Ok();
        }

        [HttpDelete("RemoveSpecie")]
        public async Task<IActionResult> RemoveSpecie(int id)
        {
            await _specieService.Remove(id);
            return Ok();
        }
    }
}
