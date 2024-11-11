using MediatR;
using SmartVet.Application.Species.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (specie == null)
            {
                throw new ApplicationException("Error creating entity"); 
            }
            else
            {
                return await _baseRepository.Add(specie);
            }
        }
    }
}
