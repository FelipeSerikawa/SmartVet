using MediatR;
using SmartVet.Application.Customers.Queries;
using SmartVet.Application.Roles.Queries;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Roles.Handlers
{
    public class GetRoleByIdQueryHandler : IRequestHandler<GetRoleByIdQuery, Role>
    {
        private readonly IBaseRepository<Role> _baseRepository;

        public GetRoleByIdQueryHandler(IBaseRepository<Role> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Role> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
        {
            var role = await _baseRepository.GetById(request.Id);

            if (role == null) throw new ApplicationException("Role not found");

            return role;
        }
    }
}
