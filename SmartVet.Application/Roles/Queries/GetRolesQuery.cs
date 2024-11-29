using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Roles.Queries
{
    public class GetRolesQuery : IRequest<IEnumerable<Role>>
    {
    }
}
