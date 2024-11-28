using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Customers.Commands
{
    public class CustomerRemoveCommand : IRequest<Customer>
    {
        public int Id { get; set; }

        public CustomerRemoveCommand(int id)
        {
            Id = id;
        }
    }
}
