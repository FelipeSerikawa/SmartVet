using MediatR;
using SmartVet.Application.Customers.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

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

            if (customer == null) throw new ApplicationException("Customer not found to update!");

            customer.Name = request.Name;
            customer.Phone = request.Phone;
            customer.Email = request.Email;
            customer.Address = request.Address;
            customer.DateOfBirth = request.DateOfBirth;
            customer.IdentificationDocument = request.IdentificationDocument;
            customer.LastModifiedBy = 0;
            customer.LastModifiedDate = DateTime.Now;

            return await _baseRepository.Update(customer);
        }
    }
}
