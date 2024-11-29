using AutoMapper;
using SmartVet.Application.Customers.Commands;
using SmartVet.Application.Species.Commands;
using SmartVet.Application.DTOs.Customer;
using SmartVet.Application.Customers.Queries;
using SmartVet.Application.DTOs.Specie;
using SmartVet.Application.Species.Queries;
using SmartVet.Application.DTOs.Animal;
using SmartVet.Application.Animals.Commands;
using SmartVet.Application.Animals.Queries;
using SmartVet.Application.DTOs.Role;
using SmartVet.Application.Roles.Commands;
using SmartVet.Application.Roles.Queries;

namespace SmartVet.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            //Customer
            CreateMap<CustomerCreateDTO, CustomerCreateCommand>();
            CreateMap<CustomerResponseDTO, GetCustomerByIdQuery>();
            CreateMap<CustomerUpdateDTO, CustomerUpdateCommand>();

            //Specie
            CreateMap<SpecieCreateDTO, SpecieCreateCommand>();
            CreateMap<SpecieResponseDTO, GetSpecieByIdQuery>();
            CreateMap<SpecieUpdateDTO, SpecieUpdateCommand>();

            //Animal
            CreateMap<AnimalCreateDTO, AnimalCreateCommand>();
            CreateMap<AnimalResponseDTO, GetAnimalByIdQuery>();
            CreateMap<AnimalUpdateDTO, AnimalUpdateCommand>();

            //Role
            CreateMap<RoleCreateDTO, RoleCreateCommand>();
            CreateMap<RoleResponseDTO, GetRoleByIdQuery>();
            CreateMap<RoleUpdateDTO, RoleUpdateCommand>();
        }
    }
}
