using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Appointments.Commands
{
    public class AppointmentCommand : IRequest<Appointment>
    {
        public int AnimalId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string? Reason { get; set; }
        public string? Diagnosis { get; set; }
        public string? Treatment { get; set; }
    }
}
