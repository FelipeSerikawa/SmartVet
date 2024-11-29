using MediatR;
using SmartVet.Application.Employees.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Employees.Handlers
{
    public class EmployeeCreateCommandHandler : IRequestHandler<EmployeeCreateCommand, Employee>
    {
        private readonly IBaseRepository<Employee> _baseRepository;

        public EmployeeCreateCommandHandler(IBaseRepository<Employee> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Employee> Handle(EmployeeCreateCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee(request.RoleId, request.Name, request.Phone, request.Email, request.Address, request.DateOfBirth, request.IdentificationDocument);

            employee.CreatedDate = DateTime.Now;
            employee.CreatedBy = 0;

            return await _baseRepository.Add(employee);
        }
    }
}
