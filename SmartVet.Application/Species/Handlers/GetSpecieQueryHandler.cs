using MediatR;
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
    public class GetSpecieQueryHandler : IRequestHandler<GetSpecieQuery, IEnumerable<Specie>>
    {
        private readonly IBaseRepository<Specie> _baseRepository;

        public GetSpecieQueryHandler(IBaseRepository<Specie> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<IEnumerable<Specie>> Handle(GetSpecieQuery request, CancellationToken cancellationToken)
        {
            return await _baseRepository.GetAll();
        }
    }
}
