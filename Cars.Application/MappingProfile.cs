using AutoMapper;
using Cars.Application.DTO;
using Cars.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CarsDto, Domain.Models.Cars>();
            CreateMap<Cars.Domain.Models.Cars, CarsDto>();
        }
    }
}
