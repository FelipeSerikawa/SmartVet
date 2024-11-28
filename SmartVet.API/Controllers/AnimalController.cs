using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.DTOs.Animal;
using SmartVet.Application.Interfaces;

namespace SmartVet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalService _animalService;

        public AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [HttpGet("GetAnimalById")]
        public async Task<IActionResult> GetAnimalById(int id)
        {
            var animal = await _animalService.GetById(id);
            return Ok(animal);
        }

        [HttpGet("GetAnimals")]
        public async Task<IActionResult> GetAnimals()
        {
            var animals = await _animalService.GetAll();
            return Ok(animals);
        }

        [HttpPost("AddAnimal")]
        public async Task<IActionResult> AddAnimal(AnimalCreateDTO animal)
        {
            await _animalService.Add(animal);
            return Ok();
        }

        [HttpPut("UpdateAnimal")]
        public async Task<IActionResult> UpdateAnimal(AnimalUpdateDTO animal)
        {
            await _animalService.Update(animal);
            return Ok();
        }

        [HttpDelete("RemoveAnimal")]
        public async Task<IActionResult> RemoveAnimal(int id)
        {
            await _animalService.Remove(id);
            return Ok();
        }
    }
}
