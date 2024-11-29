using SmartVet.Application.DTOs.Role;

namespace SmartVet.Application.Interfaces
{
    public interface IRoleService
    {
        Task<RoleResponseDTO> GetById(int id);
        Task<IEnumerable<RoleResponseDTO>> GetAll();
        Task Add(RoleCreateDTO dto);
        Task Update(RoleUpdateDTO dto);
        Task Remove(int id);
    }
}
