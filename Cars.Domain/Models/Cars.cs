using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Domain.Models
{
    internal class Cars
    {
        public Guid CarId { get; set; }
        public int TotalWeight { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
    }
}
