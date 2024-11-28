using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Animals.Queries
{
    public class GetAnimalByIdQuery : IRequest<Animal>
    {
        public int Id { get; set; }

        public GetAnimalByIdQuery(int id)
        {
            Id = id;
        }
    }
}
