using SmartVet.Application.DTOs.Animal;
using SmartVet.Application.DTOs.Appointment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Interfaces
{
    public interface IAppointmentService
    {
        Task<AppointmentResponseDTO> GetById(int id);
        Task<IEnumerable<AppointmentResponseDTO>> GetAll();
        Task Add(AppointmentCreateDTO dto);
        Task Update(AppointmentUpdateDTO dto);
        Task Remove(int id);
    }
}
