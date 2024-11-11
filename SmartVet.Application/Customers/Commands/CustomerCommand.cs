using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Customers.Commands
{
    public abstract class CustomerCommand : IRequest<Customer>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string IdentificationDocument { get; set; }
    }
}
