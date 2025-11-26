using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Interfaces
{
    public interface ICarsStorage
    {
        Task<List<Cars.Domain.Models.Cars>> GetALlCars();
        Task<Cars.Domain.Models.Cars> GetCarById(Guid id);
        Task<Guid> AddCarAsync(Cars.Domain.Models.Cars item);
        Task UpdateCarAsync(Guid id, Cars.Domain.Models.Cars item);
        Task DeleteCarAsync(Guid id);
    }
}
