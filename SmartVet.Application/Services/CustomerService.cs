using AutoMapper;
using MediatR;
using SmartVet.Application.Customers.Commands;
using SmartVet.Application.Customers.Queries;
using SmartVet.Application.DTOs;
using SmartVet.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task Add(CustomerDTO dto)
        {
            dto.CreatedDate = DateTime.UtcNow;
            dto.CreatedBy = 0;
            var customerCreateCommand = _mapper.Map<CustomerCreateCommand>(dto);
            await _mediator.Send(customerCreateCommand);
        }

        public async Task<IEnumerable<CustomerDTO>> GetAll()
        {
            var customerQuery = new GetCustomerQuery();

            if (customerQuery == null) 
            {
                throw new Exception("Entity could not be loaded.");
            }

            var result = await _mediator.Send(customerQuery);

            return _mapper.Map<IEnumerable<CustomerDTO>>(result);
        }

        public async Task<CustomerDTO> GetById(int id)
        {
            var customerQuery = new GetCustomerByIdQuery(id);

            if (customerQuery == null)
            {
                throw new Exception("Entity could not be loaded.");
            }

            var result = await _mediator.Send(customerQuery);

            return _mapper.Map<CustomerDTO>(result);
        }

        public async Task Update(CustomerDTO dto)
        {
            dto.LastModifiedDate = DateTime.UtcNow;
            dto.LastModifiedBy = 0;
            var customerUpdateCommand = _mapper.Map<CustomerUpdateCommand>(dto);
            await _mediator.Send(customerUpdateCommand);
        }

        public async Task Remove(int id)
        {
            var customerRemoveCommand = new CustomerRemoveCommand(id);

            if (customerRemoveCommand == null)
            {
                throw new Exception("Entity could not be loaded.");
            }

            await _mediator.Send(customerRemoveCommand);
        }
    }
}
