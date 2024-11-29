using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartVet.Domain.Entities;

namespace SmartVet.Infrastructure.Data.EntitiesConfiguration
{
    public class EmployeeConfiguration
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Role).WithMany(x => x.Employees).HasForeignKey(x => x.RoleId);
            builder.Property(x => x.Name).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Phone).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(250).IsRequired();
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.IdentificationDocument).HasMaxLength(250).IsRequired();
        }
    }
}
