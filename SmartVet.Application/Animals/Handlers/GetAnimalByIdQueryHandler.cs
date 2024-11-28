using MediatR;
using SmartVet.Application.Animals.Queries;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Animals.Handlers
{
    public class GetAnimalByIdQueryHandler : IRequestHandler<GetAnimalByIdQuery, Animal>
    {
        private readonly IBaseRepository<Animal> _baseRepository;

        public GetAnimalByIdQueryHandler(IBaseRepository<Animal> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Animal> Handle(GetAnimalByIdQuery request, CancellationToken cancellationToken)
        {
            var animal = await _baseRepository.GetById(request.Id);

            if (animal == null) throw new ApplicationException("Animal not found");

            return animal;
        }
    }
}
