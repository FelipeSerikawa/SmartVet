using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Animals.Queries
{
    public class GetAnimalsQuery : IRequest<IEnumerable<Animal>>
    {
    }
}
