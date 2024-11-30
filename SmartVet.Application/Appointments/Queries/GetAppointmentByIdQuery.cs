using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Appointments.Queries
{
    public class GetAppointmentByIdQuery : IRequest<Appointment>
    {
        public int Id { get; set; }

        public GetAppointmentByIdQuery(int id)
        {
            Id = id;
        }
    }
}
