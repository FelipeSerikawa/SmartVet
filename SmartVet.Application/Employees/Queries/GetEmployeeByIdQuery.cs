using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Employees.Queries
{
    public class GetEmployeeByIdQuery : IRequest<Employee>
    {
        public int Id { get; set; }

        public GetEmployeeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
