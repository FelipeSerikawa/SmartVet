using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.DTOs.Employee;
using SmartVet.Application.Interfaces;

namespace SmartVet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetEmployeeById")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _employeeService.GetById(id);
            return Ok(employee);
        }

        [HttpGet("GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _employeeService.GetAll();
            return Ok(employees);
        }

        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee(EmployeeCreateDTO employee)
        {
            await _employeeService.Add(employee);
            return Ok();
        }

        [HttpPut("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee(EmployeeUpdateDTO employee)
        {
            await _employeeService.Update(employee);
            return Ok();
        }

        [HttpDelete("RemoveEmployee")]
        public async Task<IActionResult> RemoveEmployee(int id)
        {
            await _employeeService.Remove(id);
            return Ok();
        }
    }
}
