using AutoMapper;
using SmartVet.Application.DTOs;
using SmartVet.Application.DTOs.Customer;
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
            //CreateMap<Animal, AnimalDTO>().ReverseMap();
            //CreateMap<Appointment, AppointmentDTO>().ReverseMap();
            //CreateMap<Customer, CustomerResponseDTO>().ReverseMap();
            //CreateMap<Employee, EmployeeDTO>().ReverseMap();
            //CreateMap<Role, RoleDTO>().ReverseMap();
            //CreateMap<Specie, SpecieDTO>().ReverseMap();

            //Customer
            CreateMap<Customer, CustomerResponseDTO>().ReverseMap();
            CreateMap<Customer, CustomerCreateDTO>().ReverseMap();
            CreateMap<Customer, CustomerUpdateDTO>().ReverseMap();
        }
    }
}
