using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Appointments.Commands
{
    public class AppointmentRemoveCommand : IRequest<Appointment>
    {
        public int Id { get; set; }

        public AppointmentRemoveCommand(int id)
        {
            Id = id;
        }
    }
}
