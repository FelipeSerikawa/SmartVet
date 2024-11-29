using MediatR;
using SmartVet.Application.Employees.Queries;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Employees.Handlers
{
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, IEnumerable<Employee>>
    {
        private readonly IBaseRepository<Employee> _baseRepository;

        public GetEmployeesQueryHandler(IBaseRepository<Employee> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<IEnumerable<Employee>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employee = await _baseRepository.GetAll();

            if (employee.Count() == 0) throw new ApplicationException("No employee found!");

            return employee;

        }
    }
}
