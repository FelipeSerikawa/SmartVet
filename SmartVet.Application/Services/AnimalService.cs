using AutoMapper;
using MediatR;
using SmartVet.Application.Animals.Commands;
using SmartVet.Application.Animals.Queries;
using SmartVet.Application.DTOs.Animal;
using SmartVet.Application.Interfaces;

namespace SmartVet.Application.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public AnimalService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task Add(AnimalCreateDTO dto)
        {
            var animalCreateCommand = _mapper.Map<AnimalCreateCommand>(dto);
            await _mediator.Send(animalCreateCommand);
        }

        public async Task<IEnumerable<AnimalResponseDTO>> GetAll()
        {
            var animalQuery = new GetAnimalsQuery();
            var result = await _mediator.Send(animalQuery);

            return _mapper.Map<IEnumerable<AnimalResponseDTO>>(result);
        }

        public async Task<AnimalResponseDTO> GetById(int id)
        {
            var animalQuery = new GetAnimalByIdQuery(id);
            var result = await _mediator.Send(animalQuery);

            return _mapper.Map<AnimalResponseDTO>(result);
        }

        public async Task Update(AnimalUpdateDTO dto)
        {
            var animalUpdateCommand = _mapper.Map<AnimalUpdateCommand>(dto);
            await _mediator.Send(animalUpdateCommand);
        }

        public async Task Remove(int id)
        {
            var animalRemoveCommand = new AnimalRemoveCommand(id);
            await _mediator.Send(animalRemoveCommand);
        }
    }
}
