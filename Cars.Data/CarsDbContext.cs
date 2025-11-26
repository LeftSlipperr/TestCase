using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Cars.Data
{
    public class CarsDbContext : DbContext
    {

        public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
        {
        }

        public DbSet<Cars.Domain.Models.Cars> Cars => Set<Cars.Domain.Models.Cars>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var assembly = Assembly.GetExecutingAssembly();
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

        }
    }
}
