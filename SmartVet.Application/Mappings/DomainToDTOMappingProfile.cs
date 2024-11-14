using AutoMapper;
using SmartVet.Application.DTOs;
using SmartVet.Application.DTOs.Customer;
using SmartVet.Application.DTOs.Specie;
using SmartVet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            //Customer
            CreateMap<Customer, CustomerResponseDTO>().ReverseMap();
            CreateMap<Customer, CustomerCreateDTO>().ReverseMap();
            CreateMap<Customer, CustomerUpdateDTO>().ReverseMap();

            //Specie
            CreateMap<Specie, SpecieResponseDTO>().ReverseMap();
            CreateMap<Specie, SpecieCreateDTO>().ReverseMap();
            CreateMap<Specie, SpecieUpdateDTO>().ReverseMap();
        }
    }
}
