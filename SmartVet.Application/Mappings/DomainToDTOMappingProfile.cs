﻿using AutoMapper;
using SmartVet.Application.DTOs;
using SmartVet.Application.DTOs.Animal;
using SmartVet.Application.DTOs.Appointment;
using SmartVet.Application.DTOs.Customer;
using SmartVet.Application.DTOs.Employee;
using SmartVet.Application.DTOs.Role;
using SmartVet.Application.DTOs.Specie;
using SmartVet.Domain.Entities;
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

            //Animal
            CreateMap<Animal, AnimalResponseDTO>().ReverseMap();
            CreateMap<Animal, AnimalCreateDTO>().ReverseMap();
            CreateMap<Animal, AnimalUpdateDTO>().ReverseMap();

            //Role
            CreateMap<Role, RoleResponseDTO>().ReverseMap();
            CreateMap<Role, RoleCreateDTO>().ReverseMap();
            CreateMap<Role, RoleUpdateDTO>().ReverseMap();

            //Employee
            CreateMap<Employee, EmployeeResponseDTO>().ReverseMap();
            CreateMap<Employee, EmployeeCreateDTO>().ReverseMap();
            CreateMap<Employee, EmployeeUpdateDTO>().ReverseMap();

            //Appointment
            CreateMap<Appointment, AppointmentResponseDTO>().ReverseMap();
            CreateMap<Appointment, AppointmentCreateDTO>().ReverseMap();
            CreateMap<Appointment, AppointmentUpdateDTO>().ReverseMap();
        }
    }
}
