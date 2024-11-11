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
    public class CustomerRemoveCommandHandler : IRequestHandler<CustomerRemoveCommand, Customer>
    {
        private readonly IBaseRepository<Customer> _baseRepository;

        public CustomerRemoveCommandHandler(IBaseRepository<Customer> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Customer> Handle(CustomerRemoveCommand request, CancellationToken cancellationToken)
        {
            var customer = await _baseRepository.GetById(request.Id);

            if (customer == null)
            {
                throw new ApplicationException("Entity could not be found.");
            }
            else
            {
                return await _baseRepository.Delete(customer);
            }
        }
    }
}
