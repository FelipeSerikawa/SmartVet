using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Appointments.Queries
{
    public class GetAppointmentsQuery : IRequest<IEnumerable<Appointment>>
    {
    }
}
