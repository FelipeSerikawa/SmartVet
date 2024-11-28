using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Animals.Commands
{
    public class AnimalCommand : IRequest<Animal>
    {
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public int SpecieId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public float? Weight { get; set; }
        public Customer? Customer { get; set; }
        public Specie? Specie { get; set; }
    }
}
