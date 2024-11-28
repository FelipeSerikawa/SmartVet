using SmartVet.Application.DTOs.Customer;

namespace SmartVet.Application.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerResponseDTO> GetById(int id);
        Task<IEnumerable<CustomerResponseDTO>> GetAll();
        Task Add(CustomerCreateDTO dto);
        Task Update(CustomerUpdateDTO dto);
        Task Remove(int id);
    }
}
