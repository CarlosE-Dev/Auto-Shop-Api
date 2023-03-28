using Auto_Shop.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Auto_Shop.Infra.Data.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("AS_USERS");

            builder.HasKey(k => k.Id);
            
            builder.Property(p => p.Username)
                .IsRequired()
                    .HasMaxLength(50);

            builder.HasIndex(u => u.Username).IsUnique();

            builder.Property(p => p.Password)
                    .IsRequired()
                        .HasMaxLength(50);
        }
    }
}
