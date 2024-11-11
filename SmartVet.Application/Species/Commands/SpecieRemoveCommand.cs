using MediatR;
using SmartVet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Species.Commands
{
    public class SpecieRemoveCommand : IRequest<Specie>
    {
        public int Id { get; set; }

        public SpecieRemoveCommand(int id)
        {
            Id = id;
        }
    }
}
