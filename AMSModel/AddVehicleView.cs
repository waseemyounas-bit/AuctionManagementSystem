using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSModels
{
    public class AddVehicleView
    {
        public Guid Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Length should be in between 3 and 100")]
        public string? FullName { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Range(2000, 2023, ErrorMessage = "Please enter valid integer Number")]
        public int Year { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Enter Car Manufacture")]
        public string? Make { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Enter Model")]
        public string? Model { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Enter VIN")]
        public string? VIN { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Enter Current odometer reading")]
        public string? COR { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Enter Current odometer reading")]
        public int? CORType { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Enter Current odometer reading")]
        public int? odometerreadingreflect { get; set; }
        public string? OORMilegeRemarks { get; set; }
       // Vehicle History & Condition
        [Required(AllowEmptyStrings = false)]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Enter Current odometer reading")]
        public string? VehiclePurchaseMoth { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Enter Current odometer reading")]
        public string? VehiclePurchaseYear { get; set; }
        public string? Vmiles { get; set; }
        public string? mileageDistanceUnit { get; set; }
        public string? VownershipRemarks { get; set; }
        public string? Vaccident { get; set; }
        public string? VaccidentRemarks { get; set; }
        public int? VDamage { get; set; }
        public string? VDamageRemarks { get; set; }
        //Ownership, Title & Location
        public int? VSeller { get; set; }
        public string? DealerName { get; set; }
        public string? OwnerDetails { get; set; }
        public String Vtitled { get; set; }
        public string? VtitledRemarks { get; set; }
        public int? TitleStatus { get; set; }
        public int? TitleState { get; set; }
        public string? VehicleLocated { get; set; }
        public string? Reserve { get; set; }
        public string? ReserveRemaks { get; set; }
        public string? AdInfoRemarks { get; set; }
        //public string Images { get; set; }
        public string ImagePath { get; set; }
    }
}
