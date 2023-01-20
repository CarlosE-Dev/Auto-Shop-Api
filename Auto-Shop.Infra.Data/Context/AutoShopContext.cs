using Auto_Shop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Auto_Shop.Infra.Data.Context
{
    public class AutoShopContext : DbContext
    {
        public AutoShopContext(DbContextOptions<AutoShopContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AutoShopContext).Assembly);

            #region Initial Data For DB

            modelBuilder.Entity<Brand>()
            .HasData(
                AutoShopDbSeeder.Ford, 
                AutoShopDbSeeder.Honda, 
                AutoShopDbSeeder.Toyota, 
                AutoShopDbSeeder.Fiat, 
                AutoShopDbSeeder.Volkswagen
                );

            modelBuilder.Entity<Vehicle>()
            .HasData(
                AutoShopDbSeeder.Focus,
                AutoShopDbSeeder.Civic,
                AutoShopDbSeeder.Corolla,
                AutoShopDbSeeder.Uno,
                AutoShopDbSeeder.Nivus
                );

            #endregion
        }
    }
}
