using MediatR;
using SmartVet.Application.Species.Queries;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Species.Handlers
{
    public class GetSpecieQueryHandler : IRequestHandler<GetSpecieQuery, IEnumerable<Specie>>
    {
        private readonly IBaseRepository<Specie> _baseRepository;

        public GetSpecieQueryHandler(IBaseRepository<Specie> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<IEnumerable<Specie>> Handle(GetSpecieQuery request, CancellationToken cancellationToken)
        {
            var specie = await _baseRepository.GetAll();

            if (specie.Count() == 0) throw new ApplicationException("No species found!");

            return specie;
        }
    }
}
