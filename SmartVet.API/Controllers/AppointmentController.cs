using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.DTOs.Appointment;
using SmartVet.Application.Interfaces;

namespace SmartVet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet("GetAppointmentById")]
        public async Task<IActionResult> GetAppointmentById(int id)
        {
            var appointment = await _appointmentService.GetById(id);
            return Ok(appointment);
        }

        [HttpGet("GetAppointments")]
        public async Task<IActionResult> GetAppointments()
        {
            var appointments = await _appointmentService.GetAll();
            return Ok(appointments);
        }

        [HttpPost("AddAppointment")]
        public async Task<IActionResult> AddAppointment(AppointmentCreateDTO appointment)
        {
            await _appointmentService.Add(appointment);
            return Ok();
        }

        [HttpPut("UpdateAppointment")]
        public async Task<IActionResult> UpdateAppointment(AppointmentUpdateDTO appointment)
        {
            await _appointmentService.Update(appointment);
            return Ok();
        }

        [HttpDelete("RemoveAppointment")]
        public async Task<IActionResult> RemoveAppointment(int id)
        {
            await _appointmentService.Remove(id);
            return Ok();
        }
    }
}
