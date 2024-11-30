using MediatR;
using SmartVet.Application.Appointments.Queries;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Appointments.Handlers
{
    public class GetAppointmentsQueryHandler : IRequestHandler<GetAppointmentsQuery, IEnumerable<Appointment>>
    {
        private readonly IBaseRepository<Appointment> _baseRepository;

        public GetAppointmentsQueryHandler(IBaseRepository<Appointment> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<IEnumerable<Appointment>> Handle(GetAppointmentsQuery request, CancellationToken cancellationToken)
        {
            var appointments = await _baseRepository.GetAll();

            if (appointments.Count() == 0) throw new ApplicationException("No appointment found!");

            return appointments;

        }
    }
}
