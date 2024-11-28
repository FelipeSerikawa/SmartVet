using SmartVet.Application.DTOs.Animal;

namespace SmartVet.Application.Interfaces
{
    public interface IAnimalService
    {
        Task<AnimalResponseDTO> GetById(int id);
        Task<IEnumerable<AnimalResponseDTO>> GetAll();
        Task Add(AnimalCreateDTO dto);
        Task Update(AnimalUpdateDTO dto);
        Task Remove(int id);
    }
}
