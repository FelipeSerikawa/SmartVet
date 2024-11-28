using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Species.Queries
{
    public class GetSpecieQuery : IRequest<IEnumerable<Specie>>
    {
    }
}
