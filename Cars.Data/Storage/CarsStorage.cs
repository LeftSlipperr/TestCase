using Cars.Application.Interfaces;
using Cars.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Data.Storage
{
    public class CarsStorage : ICarsStorage
    {
        private CarsDbContext _dbContext;

        public CarsStorage(CarsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Cars.Domain.Models.Cars>> GetALlCars()
        {
            var toGet = await _dbContext.Cars.ToListAsync();
            return toGet;
        }

        public async Task<Cars.Domain.Models.Cars> GetCarById(Guid id)
        {
            var toGet = await _dbContext.Cars
                .Where(d => d.CarId == id).FirstOrDefaultAsync();
            return toGet;
        }

        public async Task<Guid> AddCarAsync(Cars.Domain.Models.Cars item)
        {
            if (item.CarId == Guid.Empty)
            {
                item.CarId = Guid.NewGuid();
            }

            await _dbContext.Cars.AddAsync(item);
            await _dbContext.SaveChangesAsync();
            return item.CarId;
        }

        public async Task UpdateCarAsync(Guid id, Cars.Domain.Models.Cars item)
        {
            Cars.Domain.Models.Cars toUpdate = await _dbContext.Cars
               .FirstOrDefaultAsync(d => d.CarId == id);

            if (toUpdate != null)
            {
                toUpdate.Model = item.Model;
                toUpdate.TotalWeight = item.TotalWeight;
                toUpdate.Type = item.Type;

                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteCarAsync(Guid id)
        {
            var toDelete = await _dbContext.Cars
                .FirstOrDefaultAsync(d => d.CarId == id);

            if (toDelete != null)
            {
                _dbContext.Cars.Remove(toDelete);
                await _dbContext.SaveChangesAsync();
            }
        }

    }
}
