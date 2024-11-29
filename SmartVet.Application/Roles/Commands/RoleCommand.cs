using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Roles.Commands
{
    public class RoleCommand : IRequest<Role>
    {
        public string Description { get; set; }
    }
}
