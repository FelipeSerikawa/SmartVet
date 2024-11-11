using MediatR;
using SmartVet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Customers.Queries
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public int Id { get; set; }

        public GetCustomerByIdQuery(int id)
        {
            Id = id;
        }
    }
}
