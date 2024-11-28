using MediatR;
using SmartVet.Application.Species.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Species.Handlers
{
    public class SpecieCreateCommandHandler : IRequestHandler<SpecieCreateCommand, Specie>
    {
        private readonly IBaseRepository<Specie> _baseRepository;

        public SpecieCreateCommandHandler(IBaseRepository<Specie> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Specie> Handle(SpecieCreateCommand request, CancellationToken cancellationToken)
        {
            var specie = new Specie(request.Name);

            specie.CreatedDate = DateTime.Now;
            specie.CreatedBy = 0;

            return await _baseRepository.Add(specie);
        }
    }
}
