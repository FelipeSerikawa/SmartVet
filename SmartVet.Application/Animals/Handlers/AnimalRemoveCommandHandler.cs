using MediatR;
using SmartVet.Application.Animals.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Animals.Handlers
{
    public class AnimalRemoveCommandHandler : IRequestHandler<AnimalRemoveCommand, Animal>
    {
        private readonly IBaseRepository<Animal> _baseRepository;

        public AnimalRemoveCommandHandler(IBaseRepository<Animal> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Animal> Handle(AnimalRemoveCommand request, CancellationToken cancellationToken)
        {
            var animal = await _baseRepository.GetById(request.Id);

            if (animal == null) throw new ApplicationException("Animal not found to remove!");

            return await _baseRepository.Delete(animal);
        }
    }
}
