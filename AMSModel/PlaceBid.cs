using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSModels
{
    public class PlaceBid
    {
        public Guid Id { get; set; }
        public Guid? Userid { get; set; }
        public User? User { get; set; }
        public string? BidAmount { get; set; }
        public DateTime BidTime { get; set; } =DateTime.Now;
        public Guid? VehicleId { get; set; }
        public AddVehicle? AddVehicle { get; set; }
        public DateTime CreatedDate { get; set; }=DateTime.Now;

    }
}
