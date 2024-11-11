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
    public class CustomerUpdateCommandHandler : IRequestHandler<CustomerUpdateCommand, Customer>
    {
        private readonly IBaseRepository<Customer> _baseRepository;

        public CustomerUpdateCommandHandler(IBaseRepository<Customer> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Customer> Handle(CustomerUpdateCommand request, CancellationToken cancellationToken)
        {
            var customer = await _baseRepository.GetById(request.Id);

            if (customer == null) 
            { 
                throw new ApplicationException("Entity could not be found."); 
            }
            else
            {
                customer.Name = request.Name;
                customer.Phone = request.Phone;
                customer.Email = request.Email;
                customer.Address = request.Address;
                customer.DateOfBirth = request.DateOfBirth;
                customer.IdentificationDocument = request.IdentificationDocument;

                return await _baseRepository.Update(customer);
            }
        }
    }
}
