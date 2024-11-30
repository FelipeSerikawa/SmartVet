using MediatR;
using SmartVet.Application.Appointments.Queries;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Appointments.Handlers
{
    public class GetAppointmentByIdQueryHandler : IRequestHandler<GetAppointmentByIdQuery, Appointment>
    {
        private readonly IBaseRepository<Appointment> _baseRepository;

        public GetAppointmentByIdQueryHandler(IBaseRepository<Appointment> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Appointment> Handle(GetAppointmentByIdQuery request, CancellationToken cancellationToken)
        {
            var appointment = await _baseRepository.GetById(request.Id);

            if (appointment == null) throw new ApplicationException("Appointment not found");

            return appointment;
        }
    }
}
