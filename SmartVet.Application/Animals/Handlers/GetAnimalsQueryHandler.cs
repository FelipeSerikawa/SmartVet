using MediatR;
using SmartVet.Application.Animals.Queries;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Animals.Handlers
{
    public class GetAnimalsQueryHandler : IRequestHandler<GetAnimalsQuery, IEnumerable<Animal>>
    {
        private readonly IBaseRepository<Animal> _baseRepository;

        public GetAnimalsQueryHandler(IBaseRepository<Animal> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<IEnumerable<Animal>> Handle(GetAnimalsQuery request, CancellationToken cancellationToken)
        {
            var animals = await _baseRepository.GetAll();

            if (animals.Count() == 0) throw new ApplicationException("No animal found!");

            return animals;

        }
    }
}

