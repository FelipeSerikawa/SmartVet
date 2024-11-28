using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartVet.Domain.Entities;

namespace SmartVet.Infrastructure.Data.EntitiesConfiguration
{
    public class CustomerConfiguration
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Phone).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(250).IsRequired();
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.IdentificationDocument).HasMaxLength(250).IsRequired();
        }
    }
}
