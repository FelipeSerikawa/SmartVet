using MediatR;
using SmartVet.Application.Roles.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Roles.Handlers
{
    public class RoleCreateCommandHandler : IRequestHandler<RoleCreateCommand, Role>
    {
        private readonly IBaseRepository<Role> _baseRepository;

        public RoleCreateCommandHandler(IBaseRepository<Role> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Role> Handle(RoleCreateCommand request, CancellationToken cancellationToken)
        {
            var role = new Role(request.Description);

            role.CreatedDate = DateTime.Now;
            role.CreatedBy = 0;

            return await _baseRepository.Add(role);
        }
    }
}
