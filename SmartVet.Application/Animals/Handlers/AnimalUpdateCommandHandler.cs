using MediatR;
using SmartVet.Application.Animals.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Animals.Handlers
{
    public class AnimalUpdateCommandHandler : IRequestHandler<AnimalUpdateCommand, Animal>
    {
        private readonly IBaseRepository<Animal> _baseRepository;

        public AnimalUpdateCommandHandler(IBaseRepository<Animal> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Animal> Handle(AnimalUpdateCommand request, CancellationToken cancellationToken)
        {
            var animal = await _baseRepository.GetById(request.Id);

            if (animal == null) throw new ApplicationException("Animal not found to update!");

            animal.Name = request.Name;
            animal.CustomerId = request.CustomerId;
            animal.SpecieId = request.SpecieId;
            animal.DateOfBirth = request.DateOfBirth;
            animal.Weight = request.Weight;
            animal.LastModifiedBy = 0;
            animal.LastModifiedDate = DateTime.Now;

            return await _baseRepository.Update(animal);
        }
    }
}
