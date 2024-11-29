using MediatR;
using SmartVet.Application.Employees.Queries;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Employees.Handlers
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly IBaseRepository<Employee> _baseRepository;

        public GetEmployeeByIdQueryHandler(IBaseRepository<Employee> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employee = await _baseRepository.GetById(request.Id);

            if (employee == null) throw new ApplicationException("Employee not found");

            return employee;
        }
    }
}
