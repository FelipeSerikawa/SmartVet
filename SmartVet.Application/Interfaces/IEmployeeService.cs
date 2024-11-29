using SmartVet.Application.DTOs.Employee;

namespace SmartVet.Application.Interfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeResponseDTO> GetById(int id);
        Task<IEnumerable<EmployeeResponseDTO>> GetAll();
        Task Add(EmployeeCreateDTO dto);
        Task Update(EmployeeUpdateDTO dto);
        Task Remove(int id);
    }
}
