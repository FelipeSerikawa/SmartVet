using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartVet.Domain.Entities;

namespace SmartVet.Infrastructure.Data.EntitiesConfiguration
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(250).IsRequired();
            builder.HasOne(x => x.Customer).WithMany(x => x.Animals).HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.Specie).WithMany(x => x.Animals).HasForeignKey(x => x.SpecieId);
        }
    }
}
