using MediatR;
using SmartVet.Application.Appointments.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Appointments.Handlers
{
    public class AppointmentRemoveCommandHandler : IRequestHandler<AppointmentRemoveCommand, Appointment>
    {
        private readonly IBaseRepository<Appointment> _baseRepository;

        public AppointmentRemoveCommandHandler(IBaseRepository<Appointment> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Appointment> Handle(AppointmentRemoveCommand request, CancellationToken cancellationToken)
        {
            var appointment = await _baseRepository.GetById(request.Id);

            if (appointment == null) throw new ApplicationException("Appointment not found to remove!");

            return await _baseRepository.Delete(appointment);
        }
    }
}
