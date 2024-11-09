using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
            
            services.AddScoped<IBaseRepository<Animal>, BaseRepository<Animal>>();

            return services;
        }
    }
}
