using AutoMapper;
using MediatR;
using SmartVet.Application.Employees.Commands;
using SmartVet.Application.Employees.Queries;
using SmartVet.Application.DTOs.Employee;
using SmartVet.Application.Interfaces;

namespace SmartVet.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public EmployeeService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task Add(EmployeeCreateDTO dto)
        {
            var employeeCreateCommand = _mapper.Map<EmployeeCreateCommand>(dto);
            await _mediator.Send(employeeCreateCommand);
        }

        public async Task<IEnumerable<EmployeeResponseDTO>> GetAll()
        {
            var employeeQuery = new GetEmployeesQuery();
            var result = await _mediator.Send(employeeQuery);

            return _mapper.Map<IEnumerable<EmployeeResponseDTO>>(result);
        }

        public async Task<EmployeeResponseDTO> GetById(int id)
        {
            var employeeQuery = new GetEmployeeByIdQuery(id);
            var result = await _mediator.Send(employeeQuery);

            return _mapper.Map<EmployeeResponseDTO>(result);
        }

        public async Task Update(EmployeeUpdateDTO dto)
        {
            var employeeUpdateCommand = _mapper.Map<EmployeeUpdateCommand>(dto);
            await _mediator.Send(employeeUpdateCommand);
        }

        public async Task Remove(int id)
        {
            var employeeRemoveCommand = new EmployeeRemoveCommand(id);
            await _mediator.Send(employeeRemoveCommand);
        }
    }
}
