using MediatR;
using SmartVet.Application.Appointments.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Appointments.Handlers
{
    public class AppointmentCreateCommandHandler : IRequestHandler<AppointmentCreateCommand, Appointment>
    {
        private readonly IBaseRepository<Appointment> _baseRepository;

        public AppointmentCreateCommandHandler(IBaseRepository<Appointment> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Appointment> Handle(AppointmentCreateCommand request, CancellationToken cancellationToken)
        {
            var appointment = new Appointment(request.AnimalId, request.EmployeeId, request.AppointmentDate, request.Reason, request.Diagnosis, request.Treatment);

            appointment.CreatedDate = DateTime.Now;
            appointment.CreatedBy = 0;

            return await _baseRepository.Add(appointment);
        }
    }
}
