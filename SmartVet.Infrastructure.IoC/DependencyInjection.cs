﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartVet.Application.DTOs;
using SmartVet.Application.Interfaces;
using SmartVet.Application.Mappings;
using SmartVet.Application.Services;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;
using SmartVet.Infrastructure.Data.Context;
using SmartVet.Infrastructure.Data.Repositories;


namespace SmartVet.Infrastructure.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));
            
            services.AddScoped<ISpecieService, SpecieService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IBaseRepository<Specie>, BaseRepository<Specie>>();
            services.AddScoped<IBaseRepository<Customer>, BaseRepository<Customer>>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            var myHandlers = AppDomain.CurrentDomain.Load("SmartVet.Application");
            services.AddMediatR(m => m.RegisterServicesFromAssembly(myHandlers));

            return services;
        }
    }
}
