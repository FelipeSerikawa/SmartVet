using MediatR;
using SmartVet.Application.Customers.Queries;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

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
            var customers = await _baseRepository.GetAll();

            if (customers.Count() == 0) throw new ApplicationException("No customers found!");

            return customers;

        }
    }
}
