using MediatR;
using SmartVet.Application.Species.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Species.Handlers
{
    public class SpecieRemoveCommandHandler : IRequestHandler<SpecieRemoveCommand, Specie>
    {
        private readonly IBaseRepository<Specie> _baseRepository;

        public SpecieRemoveCommandHandler(IBaseRepository<Specie> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Specie> Handle(SpecieRemoveCommand request, CancellationToken cancellationToken)
        {
            var specie = await _baseRepository.GetById(request.Id);

            if (specie == null) throw new ApplicationException("Specie not found to remove!");

            return await _baseRepository.Delete(specie);
        }
    }
}
