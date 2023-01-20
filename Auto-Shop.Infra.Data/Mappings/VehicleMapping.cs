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

            builder.Property(p => p.BrandId)
                    .IsRequired();

            builder.Property(p => p.Year)
                    .IsRequired()
                        .HasMaxLength(9);

            builder.Property(p => p.Model)
                    .IsRequired()
                        .HasMaxLength(50);

            // TODO: insert a generic link for no img

            builder.Property(p => p.ImageUrl)
                    .HasMaxLength(500)
                        .HasDefaultValue("http://");

            builder.Property(p => p.City)
                    .IsRequired()
                        .HasMaxLength(100);

            builder.Property(p => p.State)
                    .IsRequired()
                        .HasMaxLength(2);

            builder.Property(p => p.Km)
                    .IsRequired()
                        .HasMaxLength(9);

            builder.Property(p => p.Price)
                    .IsRequired();

            builder.HasOne(p => p.Brand)
                    .WithMany(p => p.Vehicles)
                        .HasForeignKey(k => k.BrandId)
                            .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
