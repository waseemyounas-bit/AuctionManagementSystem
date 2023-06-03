using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSModels
{
    public class VehicleImages
    {
        public Guid Id { get; set; }
        public string ImagePath { get; set; }
        public Guid? AddVehicleId { get; set; }
        public AddVehicle? AddVehicle { get; set; }
    }
}
