using MediatR;
using SmartVet.Application.Customers.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Customers.Handlers
{
    public class CustomerCreateCommandHandler : IRequestHandler<CustomerCreateCommand, Customer>
    {
        private readonly IBaseRepository<Customer> _baseRepository;

        public CustomerCreateCommandHandler(IBaseRepository<Customer> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Customer> Handle(CustomerCreateCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer(request.Name, request.Phone, request.Email, request.Address, request.DateOfBirth, request.IdentificationDocument, request.CreatedBy);

            if (customer == null)
            {
                throw new ApplicationException("Error creating entity"); 
            }
            else
            {
                return await _baseRepository.Add(customer);
            }
        }
    }
}
