using Auto_Shop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Auto_Shop.Infra.Data.Context
{
    public class AutoShopContext : DbContext
    {
        public AutoShopContext(DbContextOptions<AutoShopContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AutoShopContext).Assembly);
        }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
