using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Employees.Commands
{
    public abstract class EmployeeCommand : IRequest<Employee>
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentificationDocument { get; set; }
    }
}
