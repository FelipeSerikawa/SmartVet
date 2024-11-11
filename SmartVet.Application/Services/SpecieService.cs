using AutoMapper;
using MediatR;
using SmartVet.Application.DTOs;
using SmartVet.Application.Interfaces;
using SmartVet.Application.Species.Commands;
using SmartVet.Application.Species.Queries;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Services
{
    public class SpecieService : ISpecieService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public SpecieService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task Add(SpecieDTO dto)
        {
            dto.CreatedDate = DateTime.UtcNow;
            dto.CreatedBy = 0;
            var specieCreateCommand = _mapper.Map<SpecieCreateCommand>(dto);
            await _mediator.Send(specieCreateCommand);
        }

        public async Task<IEnumerable<SpecieDTO>> GetAll()
        {
            var specieQuery = new GetSpecieQuery();

            if (specieQuery == null)
            {
                throw new Exception("Entity could not be loaded.");
            }

            var result = await _mediator.Send(specieQuery);

            return _mapper.Map<IEnumerable<SpecieDTO>>(result);
        }

        public async Task<SpecieDTO> GetById(int id)
        {
            var specieQuery = new GetSpecieByIdQuery(id);

            if (specieQuery == null)
            {
                throw new Exception("Entity could not be loaded.");
            }

            var result = await _mediator.Send(specieQuery);

            return _mapper.Map<SpecieDTO>(result);
        }

        public async Task Update(SpecieDTO dto)
        {
            dto.LastModifiedDate = DateTime.UtcNow;
            dto.LastModifiedBy = 0;
            var specieQueryUpdateCommand = _mapper.Map<SpecieUpdateCommand>(dto);
            await _mediator.Send(specieQueryUpdateCommand);
        }

        public async Task Remove(int id)
        {
            var specieRemoveCommand = new SpecieRemoveCommand(id);

            if (specieRemoveCommand == null)
            {
                throw new Exception("Entity could not be loaded.");
            }

            await _mediator.Send(specieRemoveCommand);
        }
    }
}
