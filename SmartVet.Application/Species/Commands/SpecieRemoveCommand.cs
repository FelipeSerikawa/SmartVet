using MediatR;
using SmartVet.Domain.Entities;

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
