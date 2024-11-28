using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Customers.Queries
{
    public class GetCustomerQuery : IRequest<IEnumerable<Customer>>
    {
    }
}
