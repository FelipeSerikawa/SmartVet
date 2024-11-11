using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.DTOs;
using SmartVet.Application.Interfaces;
using SmartVet.Application.Services;

namespace SmartVet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("GetCustomerById")]
        public async Task<CustomerDTO> GetCustomerById(int id)
        {
            return await _customerService.GetById(id);
        }

        [HttpGet("GetCustomers")]
        public async Task<IEnumerable<CustomerDTO>> GetCustomers()
        {
            return await _customerService.GetAll();
        }

        [HttpPost("AddCustomer")]
        public async Task AddCustomer(CustomerDTO customer)
        {
            await _customerService.Add(customer);
        }

        [HttpPut("UpdateCustomer")]
        public async Task UpdateCustomer(CustomerDTO customer)
        {
            await _customerService.Update(customer);
        }

        [HttpDelete("RemoveCustomer")]
        public async Task RemoveCustomer(int id)
        {
            await _customerService.Remove(id);
        }
    }
}
