using Cars.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Interfaces
{
    public interface ICarsService
    {
        Task<List<Cars.Domain.Models.Cars>> GetALlCars();
        Task<Cars.Domain.Models.Cars> GetCarById(Guid id);
        Task AddCarAsync(CarsDto item);
        Task UpdateCarAsync(Guid id, CarsDto item);
        Task DeleteCarAsync(Guid id);
    }
}
