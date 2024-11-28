using SmartVet.Application.DTOs.Specie;

namespace SmartVet.Application.Interfaces
{
    public interface ISpecieService
    {
        Task<SpecieResponseDTO> GetById(int id);
        Task<IEnumerable<SpecieResponseDTO>> GetAll();
        Task Add(SpecieCreateDTO dto);
        Task Update(SpecieUpdateDTO dto);
        Task Remove(int id);
    }
}
