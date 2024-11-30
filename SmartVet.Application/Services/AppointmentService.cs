using AutoMapper;
using MediatR;
using SmartVet.Application.Appointments.Commands;
using SmartVet.Application.Appointments.Queries;
using SmartVet.Application.DTOs.Appointment;
using SmartVet.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public AppointmentService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task Add(AppointmentCreateDTO dto)
        {
            var appointmentCreateCommand = _mapper.Map<AppointmentCreateCommand>(dto);
            await _mediator.Send(appointmentCreateCommand);
        }

        public async Task<IEnumerable<AppointmentResponseDTO>> GetAll()
        {
            var appointmentQuery = new GetAppointmentsQuery();
            var result = await _mediator.Send(appointmentQuery);

            return _mapper.Map<IEnumerable<AppointmentResponseDTO>>(result);
        }

        public async Task<AppointmentResponseDTO> GetById(int id)
        {
            var appointmentQuery = new GetAppointmentByIdQuery(id);
            var result = await _mediator.Send(appointmentQuery);

            return _mapper.Map<AppointmentResponseDTO>(result);
        }

        public async Task Update(AppointmentUpdateDTO dto)
        {
            var appointmentUpdateCommand = _mapper.Map<AppointmentUpdateCommand>(dto);
            await _mediator.Send(appointmentUpdateCommand);
        }

        public async Task Remove(int id)
        {
            var appointmentRemoveCommand = new AppointmentRemoveCommand(id);
            await _mediator.Send(appointmentRemoveCommand);
        }
    }
}
