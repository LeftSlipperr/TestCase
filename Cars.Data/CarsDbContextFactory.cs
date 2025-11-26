using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Data
{
    public class CarsDbContextFactory : IDesignTimeDbContextFactory<CarsDbContext>
    {
        public CarsDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CarsDbContext>();

            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5440;Database=postgres;Username=postgres;Password=testcase");

            return new CarsDbContext(optionsBuilder.Options);
        }
    }

}
