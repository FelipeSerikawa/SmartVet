using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.DTOs.Role;
using SmartVet.Application.Interfaces;

namespace SmartVet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet("GetRoleById")]
        public async Task<IActionResult> GetRoleById(int id)
        {
            var role = await _roleService.GetById(id);
            return Ok(role);
        }

        [HttpGet("GetRoles")]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _roleService.GetAll();
            return Ok(roles);
        }

        [HttpPost("AddRole")]
        public async Task<IActionResult> AddRole(RoleCreateDTO role)
        {
            await _roleService.Add(role);
            return Ok();
        }

        [HttpPut("UpdateRole")]
        public async Task<IActionResult> UpdateRole(RoleUpdateDTO role)
        {
            await _roleService.Update(role);
            return Ok();
        }

        [HttpDelete("RemoveRole")]
        public async Task<IActionResult> RemoveRole(int id)
        {
            await _roleService.Remove(id);
            return Ok();
        }
    }
}
