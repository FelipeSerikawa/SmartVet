using MediatR;
using SmartVet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Customers.Queries
{
    public class GetCustomerQuery : IRequest<IEnumerable<Customer>>
    {
    }
}
