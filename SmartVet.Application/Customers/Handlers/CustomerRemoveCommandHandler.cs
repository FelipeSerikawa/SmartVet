using MediatR;
using SmartVet.Application.Customers.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

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

            if (customer == null) throw new ApplicationException("Customer not found to remove!");

            return await _baseRepository.Delete(customer);
        }
    }
}
