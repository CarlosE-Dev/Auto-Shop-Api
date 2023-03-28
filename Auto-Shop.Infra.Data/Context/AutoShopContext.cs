using Auto_Shop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Auto_Shop.Infra.Data.Context
{
    public class AutoShopContext : DbContext
    {
        public AutoShopContext(DbContextOptions<AutoShopContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AutoShopContext).Assembly);

            AutoShopDbSeeder.SeedInitialData(modelBuilder);
        }
    }
}
