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
        public string? Userid { get; set; }
        public string? BidAmount { get; set; }
        public DateTime BidTime { get; set; } =DateTime.Now;
        public string BidId { get; set; }
    }
}
