using Auto_Shop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Auto_Shop.Infra.Data.Mappings
{
    public class VehicleMapping : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("AS_VEHICLES");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Name)
                    .IsRequired()
                        .HasMaxLength(255);

            builder.Property(p => p.Brand)
                    .IsRequired()
                        .HasMaxLength(100);

            builder.Property(p => p.Year)
                    .IsRequired()
                        .HasMaxLength(4);

            builder.Property(p => p.Model)
                    .IsRequired()
                        .HasMaxLength(50);

            builder.Property(p => p.ImageUrl)
                    .HasMaxLength(500);
        }
    }
}
