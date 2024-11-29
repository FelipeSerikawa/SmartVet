using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Employees.Queries
{
    public class GetEmployeesQuery : IRequest<IEnumerable<Employee>>
    {
    }
}
