using MediatR;
using SmartVet.Application.Customers.Queries;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Customers.Handlers
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, IEnumerable<Customer>>
    {
        private readonly IBaseRepository<Customer> _baseRepository;

        public GetCustomerQueryHandler(IBaseRepository<Customer> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<IEnumerable<Customer>> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            return await _baseRepository.GetAll();
        }
    }
}
