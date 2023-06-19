using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSModels
{
    public class Configuration
    {
        public Guid Id { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int AuctionDuration { get; set; }
        //Minimum amount for non reserved products
        [Required]
        [Range(1, int.MaxValue)]
        public decimal MinAmount { get; set; }
        [Required]
        [Range(1, 100)]
        public int BidStartPercentage { get; set; }
    }
}
