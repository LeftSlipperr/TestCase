using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Data.EntityConfiguration
{
    public class CarsEntityTypeConfiguration : IEntityTypeConfiguration<Cars.Domain.Models.Cars>
    {
        public void Configure(EntityTypeBuilder<Domain.Models.Cars> builder)
        {
            builder.HasKey(c => c.CarId);

            builder.Property(c => c.Type).IsRequired();
            builder.Property(c => c.Model).IsRequired();
            builder.Property(c => c.TotalWeight).HasColumnType("integer");
        }
    }
}
