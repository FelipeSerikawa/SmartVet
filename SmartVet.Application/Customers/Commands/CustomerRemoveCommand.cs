using MediatR;
using SmartVet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
