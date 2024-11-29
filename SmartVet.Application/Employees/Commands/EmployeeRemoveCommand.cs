using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Employees.Commands
{
    public class EmployeeRemoveCommand : IRequest<Employee>
    {
        public int Id { get; set; }
        public EmployeeRemoveCommand(int id)
        {
            Id = id;
        }
    }
}
