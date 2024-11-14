using SmartVet.Application.DTOs.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
