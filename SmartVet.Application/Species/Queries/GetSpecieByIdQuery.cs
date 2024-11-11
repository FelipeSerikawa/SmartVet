using MediatR;
using SmartVet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Species.Queries
{
    public class GetSpecieByIdQuery : IRequest<Specie>
    {
        public int Id { get; set; }

        public GetSpecieByIdQuery(int id)
        {
            Id = id;
        }
    }
}
