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
    public class SpecieUpdateCommandHandler : IRequestHandler<SpecieUpdateCommand, Specie>
    {
        private readonly IBaseRepository<Specie> _baseRepository;

        public SpecieUpdateCommandHandler(IBaseRepository<Specie> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Specie> Handle(SpecieUpdateCommand request, CancellationToken cancellationToken)
        {
            var specie = await _baseRepository.GetById(request.Id);

            if (specie == null) throw new ApplicationException("Specie not found to update!");

            specie.Name = request.Name;
            specie.LastModifiedBy = 0;
            specie.LastModifiedDate = DateTime.Now;

            return await _baseRepository.Update(specie);
        }
    }
}
