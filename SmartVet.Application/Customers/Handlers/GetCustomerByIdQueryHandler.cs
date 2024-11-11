using MediatR;
using SmartVet.Application.Customers.Commands;
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
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, Customer>
    {
        private readonly IBaseRepository<Customer> _baseRepository;

        public GetCustomerByIdQueryHandler(IBaseRepository<Customer> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            return await _baseRepository.GetById(request.Id);   
        }
    }
}
