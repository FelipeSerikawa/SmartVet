using SmartVet.Application.Appointments.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Appointments.Handlers
{
    public class AppointmentUpdateCommandHandler
    {
        private readonly IBaseRepository<Appointment> _baseRepository;

        public AppointmentUpdateCommandHandler(IBaseRepository<Appointment> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Appointment> Handle(AppointmentUpdateCommand request, CancellationToken cancellationToken)
        {
            var appointment = await _baseRepository.GetById(request.Id);

            if (appointment == null) throw new ApplicationException("Appointment not found to update!");

            appointment.AnimalId = request.AnimalId;
            appointment.EmployeeId = request.EmployeeId;
            appointment.Diagnosis = request.Diagnosis;
            appointment.Reason = request.Reason;
            appointment.Treatment = request.Treatment;
            appointment.AppointmentDate = request.AppointmentDate;
            appointment.LastModifiedBy = 0;
            appointment.LastModifiedDate = DateTime.Now;

            return await _baseRepository.Update(appointment);
        }
    }
}
