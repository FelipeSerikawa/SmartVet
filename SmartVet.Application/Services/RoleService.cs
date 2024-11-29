using AutoMapper;
using MediatR;
using SmartVet.Application.DTOs.Role;
using SmartVet.Application.Interfaces;
using SmartVet.Application.Roles.Commands;
using SmartVet.Application.Roles.Queries;

namespace SmartVet.Application.Services
{
    public class RoleService : IRoleService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public RoleService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task Add(RoleCreateDTO dto)
        {
            var roleCreateCommand = _mapper.Map<RoleCreateCommand>(dto);
            await _mediator.Send(roleCreateCommand);
        }

        public async Task<IEnumerable<RoleResponseDTO>> GetAll()
        {
            var rolesQuery = new GetRolesQuery();

            var result = await _mediator.Send(rolesQuery);

            return _mapper.Map<IEnumerable<RoleResponseDTO>>(result);
        }

        public async Task<RoleResponseDTO> GetById(int id)
        {
            var roleQuery = new GetRoleByIdQuery(id);

            var result = await _mediator.Send(roleQuery);

            return _mapper.Map<RoleResponseDTO>(result);
        }

        public async Task Update(RoleUpdateDTO dto)
        {
            var roleUpdateCommand = _mapper.Map<RoleUpdateCommand>(dto);
            await _mediator.Send(roleUpdateCommand);
        }

        public async Task Remove(int id)
        {
            var roleRemoveCommand = new RoleRemoveCommand(id);

            await _mediator.Send(roleRemoveCommand);
        }
    }
}
