using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Roles.Queries
{
    public class GetRoleByIdQuery : IRequest<Role>
    {
        public GetRoleByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
