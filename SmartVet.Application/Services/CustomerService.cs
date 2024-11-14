using AutoMapper;
using MediatR;
using SmartVet.Application.Customers.Commands;
using SmartVet.Application.Customers.Queries;
using SmartVet.Application.DTOs.Customer;
using SmartVet.Application.Interfaces;

namespace SmartVet.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public CustomerService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task Add(CustomerCreateDTO dto)
        {
            var customerCreateCommand = _mapper.Map<CustomerCreateCommand>(dto);
            await _mediator.Send(customerCreateCommand);
        }

        public async Task<IEnumerable<CustomerResponseDTO>> GetAll()
        {
            var customerQuery = new GetCustomerQuery();

            var result = await _mediator.Send(customerQuery);

            return _mapper.Map<IEnumerable<CustomerResponseDTO>>(result);
        }

        public async Task<CustomerResponseDTO> GetById(int id)
        {
            var customerQuery = new GetCustomerByIdQuery(id);

            var result = await _mediator.Send(customerQuery);

            return _mapper.Map<CustomerResponseDTO>(result);
        }

        public async Task Update(CustomerUpdateDTO dto)
        {
            var customerUpdateCommand = _mapper.Map<CustomerUpdateCommand>(dto);
            await _mediator.Send(customerUpdateCommand);
        }

        public async Task Remove(int id)
        {
            var customerRemoveCommand = new CustomerRemoveCommand(id);

            await _mediator.Send(customerRemoveCommand);
        }
    }
}
