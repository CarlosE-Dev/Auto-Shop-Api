using Auto_Shop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Auto_Shop.Infra.Data.Mappings
{
    public class BrandMapping : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("AS_BRANDS");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Name)
                    .IsRequired()
                        .HasMaxLength(255);

            builder.Property(p => p.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

            builder.Property(p => p.ImageUrl)
                    .HasMaxLength(500);
        }
    }
}
