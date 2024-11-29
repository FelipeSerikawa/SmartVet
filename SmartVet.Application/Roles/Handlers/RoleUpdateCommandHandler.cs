using MediatR;
using SmartVet.Application.Roles.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Roles.Handlers
{
    public class RoleUpdateCommandHandler : IRequestHandler<RoleUpdateCommand, Role>
    {
        private readonly IBaseRepository<Role> _baseRepository;

        public RoleUpdateCommandHandler(IBaseRepository<Role> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Role> Handle(RoleUpdateCommand request, CancellationToken cancellationToken)
        {
            var role = await _baseRepository.GetById(request.Id);

            if (role == null) throw new ApplicationException("Role not found to update!");

            role.Description = request.Description;
            role.LastModifiedBy = 0;
            role.LastModifiedDate = DateTime.Now;

            return await _baseRepository.Update(role);
        }
    }
}
