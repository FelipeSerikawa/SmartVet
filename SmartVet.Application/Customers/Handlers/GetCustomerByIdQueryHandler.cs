using MediatR;
using SmartVet.Application.Customers.Queries;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

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
            var customer = await _baseRepository.GetById(request.Id);

            if (customer == null) throw new ApplicationException("Customer not found");

            return customer;
        }
    }
}
