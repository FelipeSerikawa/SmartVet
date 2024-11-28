using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SmartVet.Domain.Entities;

namespace SmartVet.Infrastructure.Data.EntitiesConfiguration
{
    public class SpecieConfiguration : IEntityTypeConfiguration<Specie>
    {
        public void Configure(EntityTypeBuilder<Specie> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(250).IsRequired();
        }
    }
}
