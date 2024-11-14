using MediatR;
using SmartVet.Application.Species.Commands;
using SmartVet.Application.Species.Queries;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Species.Handlers
{
    public class GetSpecieByIdQueryHandler : IRequestHandler<GetSpecieByIdQuery, Specie>
    {
        private readonly IBaseRepository<Specie> _baseRepository;

        public GetSpecieByIdQueryHandler(IBaseRepository<Specie> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Specie> Handle(GetSpecieByIdQuery request, CancellationToken cancellationToken)
        {
            var specie = await _baseRepository.GetById(request.Id);

            if (specie == null) throw new ApplicationException("Specie not found");

            return specie;
        }
    }
}
