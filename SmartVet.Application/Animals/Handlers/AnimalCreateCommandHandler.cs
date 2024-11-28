using MediatR;
using SmartVet.Application.Animals.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Animals.Handlers
{
    public class AnimalCreateCommandHandler : IRequestHandler<AnimalCreateCommand, Animal>
    {
        private readonly IBaseRepository<Animal> _baseRepository;

        public AnimalCreateCommandHandler(IBaseRepository<Animal> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Animal> Handle(AnimalCreateCommand request, CancellationToken cancellationToken)
        {
            var animal = new Animal(request.Name, request.CustomerId, request.SpecieId, request.DateOfBirth, request.Weight);

            animal.CreatedDate = DateTime.Now;
            animal.CreatedBy = 0;

            return await _baseRepository.Add(animal);
        }
    }
}
