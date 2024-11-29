using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Roles.Commands
{
    public class RoleRemoveCommand : IRequest<Role>
    {
        public RoleRemoveCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }
}
