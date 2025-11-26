using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.DTO
{
    public class CarsDto
    {
        public Guid CarId { get; set; }
        public int TotalWeight { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
    }
}
