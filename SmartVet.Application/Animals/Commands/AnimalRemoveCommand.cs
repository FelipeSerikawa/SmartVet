using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Animals.Commands
{
    public class AnimalRemoveCommand : IRequest<Animal>
    {
        public int Id { get; set; }

        public AnimalRemoveCommand(int id)
        {
            Id = id;
        }
    }
}
