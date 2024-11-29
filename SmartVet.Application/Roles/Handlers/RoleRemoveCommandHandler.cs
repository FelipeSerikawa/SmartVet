using MediatR;
using SmartVet.Application.Roles.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Roles.Handlers
{
    public class RoleRemoveCommandHandler : IRequestHandler<RoleRemoveCommand, Role>
    {
        private readonly IBaseRepository<Role> _baseRepository;

        public RoleRemoveCommandHandler(IBaseRepository<Role> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Role> Handle(RoleRemoveCommand request, CancellationToken cancellationToken)
        {
            var role = await _baseRepository.GetById(request.Id);

            if (role == null) throw new ApplicationException("Role not found to remove!");

            return await _baseRepository.Delete(role);
        }
    }
}
