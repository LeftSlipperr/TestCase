using AutoMapper;
using Cars.Application.DTO;
using Cars.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Services
{
    public class CarsService : ICarsService
    {
        private ICarsStorage _storage;
        private readonly IMapper _mapper;

        public CarsService(ICarsStorage storage, IMapper mapper)
        {
            _storage = storage;
            _mapper = mapper;
        }

        public async Task<List<Domain.Models.Cars>> GetALlCars()
        {
            var list = await _storage.GetALlCars();
            return list;
        }

        public async Task<Domain.Models.Cars> GetCarById(Guid id)
        {
            return await _storage.GetCarById(id);
        }

        public async Task AddCarAsync(CarsDto item)
        {
            var car = _mapper.Map<Domain.Models.Cars>(item);
            await _storage.AddCarAsync(car);
        }

        public async Task UpdateCarAsync(Guid id, CarsDto item)
        {
            await _storage.UpdateCarAsync(id, _mapper.Map <Domain.Models.Cars> (item));
        }

        public async Task DeleteCarAsync(Guid id)
        {
            await _storage.DeleteCarAsync(id);
        }
    }
}
