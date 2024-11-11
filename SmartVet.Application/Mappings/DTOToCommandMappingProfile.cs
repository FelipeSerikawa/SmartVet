using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmartVet.Application.Customers.Commands;
using SmartVet.Application.Species.Commands;
using SmartVet.Application.DTOs;

namespace SmartVet.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<CustomerDTO, CustomerCreateCommand>();
            CreateMap<CustomerDTO, CustomerUpdateCommand>();

            CreateMap<SpecieDTO, SpecieCreateCommand>();
            CreateMap<SpecieDTO, SpecieUpdateCommand>();
        }
    }
}
