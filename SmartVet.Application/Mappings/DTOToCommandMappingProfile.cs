using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmartVet.Application.Customers.Commands;
using SmartVet.Application.Species.Commands;
using SmartVet.Application.DTOs.Customer;
using SmartVet.Application.Customers.Queries;
using SmartVet.Application.DTOs.Specie;
using SmartVet.Application.Species.Queries;

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

            CreateMap<SpecieCreateDTO, SpecieCreateCommand>();
            CreateMap<SpecieResponseDTO, GetSpecieByIdQuery>();
            CreateMap<SpecieUpdateDTO, SpecieUpdateCommand>();
        }
    }
}
