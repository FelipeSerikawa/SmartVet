using MediatR;
using SmartVet.Application.Roles.Queries;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;

namespace SmartVet.Application.Roles.Handlers
{
    public class GetRolesQueryHandler : IRequestHandler<GetRolesQuery, IEnumerable<Role>>
    {
        private readonly IBaseRepository<Role> _baseRepository;

        public GetRolesQueryHandler(IBaseRepository<Role> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<IEnumerable<Role>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
        {
            var roles = await _baseRepository.GetAll();

            if (roles.Count() == 0) throw new ApplicationException("No roles found!");

            return roles;

        }
    }
}
