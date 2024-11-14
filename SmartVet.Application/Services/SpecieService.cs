using AutoMapper;
using MediatR;
using SmartVet.Application.Species.Commands;
using SmartVet.Application.Species.Queries;
using SmartVet.Application.DTOs.Specie;
using SmartVet.Application.Interfaces;

namespace SmartVet.Application.Services
{
    public class SpecieService : ISpecieService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public SpecieService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task Add(SpecieCreateDTO dto)
        {
            var specieCreateCommand = _mapper.Map<SpecieCreateCommand>(dto);
            await _mediator.Send(specieCreateCommand);
        }

        public async Task<IEnumerable<SpecieResponseDTO>> GetAll()
        {
            var specieQuery = new GetSpecieQuery();

            var result = await _mediator.Send(specieQuery);

            return _mapper.Map<IEnumerable<SpecieResponseDTO>>(result);
        }

        public async Task<SpecieResponseDTO> GetById(int id)
        {
            var specieQuery = new GetSpecieByIdQuery(id);

            var result = await _mediator.Send(specieQuery);

            return _mapper.Map<SpecieResponseDTO>(result);
        }

        public async Task Update(SpecieUpdateDTO dto)
        {
            var specieUpdateCommand = _mapper.Map<SpecieUpdateCommand>(dto);
            await _mediator.Send(specieUpdateCommand);
        }

        public async Task Remove(int id)
        {
            var specieRemoveCommand = new SpecieRemoveCommand(id);

            await _mediator.Send(specieRemoveCommand);
        }
    }
}
