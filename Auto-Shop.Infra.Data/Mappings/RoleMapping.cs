using Auto_Shop.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Auto_Shop.Infra.Data.Mappings
{
    internal class RoleMapping : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("AS_ROLES");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.RoleName)
                    .IsRequired()
                        .HasMaxLength(20);
        }
    }
}