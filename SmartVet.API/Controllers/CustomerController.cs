using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.DTOs.Customer;
using SmartVet.Application.Interfaces;
using SmartVet.Application.Services;
using SmartVet.Domain.Entities;

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
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var customer = await _customerService.GetById(id);
            return Ok(customer);
        }

        [HttpGet("GetCustomers")]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _customerService.GetAll();
            return Ok(customers);
        }

        [HttpPost("AddCustomer")]
        public async Task<IActionResult> AddCustomer(CustomerCreateDTO customer)
        {
            await _customerService.Add(customer);
            return Ok();
        }

        [HttpPut("UpdateCustomer")]
        public async Task<IActionResult> UpdateCustomer(CustomerUpdateDTO customer)
        {
            await _customerService.Update(customer);
            return Ok();
        }

        [HttpDelete("RemoveCustomer")]
        public async Task<IActionResult> RemoveCustomer(int id)
        {
            await _customerService.Remove(id);
            return Ok();        
        }
    }
}
