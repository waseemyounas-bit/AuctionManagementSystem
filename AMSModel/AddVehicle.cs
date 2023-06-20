﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMSModels
{
    public class AddVehicle
    {


        //[Required(AllowEmptyStrings = false)]
        //[StringLength(100, MinimumLength = 3, ErrorMessage = "Length should be in between 3 and 100")]
        public string? FullName { get; set; }
        //[Required(AllowEmptyStrings = false)]
        //[Range(2000, 2023, ErrorMessage = "Please enter valid stringeger Number")]
        public string Year { get; set; }
        //[Required(AllowEmptyStrings = false)]
        //[StringLength(100, MinimumLength = 4, ErrorMessage = "Enter Car Manufacture")]
        public string? Make { get; set; }
        //[Required(AllowEmptyStrings = false)]
        //[StringLength(100, MinimumLength = 4, ErrorMessage = "Enter Model")]
        public string Model { get; set; }
        //[Required(AllowEmptyStrings = false)]
        //[StringLength(100, MinimumLength = 4, ErrorMessage = "Enter VIN")]
        public string? VIN { get; set; }
        //[Required(AllowEmptyStrings = false)]
        //[StringLength(100, MinimumLength = 4, ErrorMessage = "Enter Current odometer reading")]
        public string? COR { get; set; }
        //[Required(AllowEmptyStrings = false)]
        //[StringLength(100, MinimumLength = 4, ErrorMessage = "Enter Current odometer reading")]
        public string? CORType { get; set; }
        //[Required(AllowEmptyStrings = false)]
        //[StringLength(1, MinimumLength = 1, ErrorMessage = "Enter Current odometer reading")]
        //  public string odometerreadingreflect { get; set; }
        public string? OORMilegeRemarks { get; set; }
        //Vehicle History & Condition
        //[Required(AllowEmptyStrings = false)]
        //[StringLength(1, MinimumLength = 1, ErrorMessage = "Enter Current odometer reading")]
        public string? VehiclePurchaseMoth { get; set; }
        //[Required(AllowEmptyStrings = false)]
        //[StringLength(1, MinimumLength = 1, ErrorMessage = "Enter Current odometer reading")]
        public string? VehiclePurchaseYear { get; set; }
        public string? Vmiles { get; set; }
        public string? mileageDistanceUnit { get; set; }
        public string? VehicleOwnerShipHistory { get; set; }
        public string? VownershipRemarks { get; set; }
        public string? Vaccident { get; set; }
        public string? btnVehicleAccident { get; set; }
        public string? VaccidentRemarks { get; set; }
        public string? VDamage { get; set; }
        public string? VDamageRemarks { get; set; }
        //Ownership, Title & Location
        //public string? VSeller { get; set; }
        ////public string? DealerName { get; set; }
        //public string? OwnerDetails { get; set; }
        //public string sellerType { get; set; }
        public string Vtitled { get; set; }
        public string? VtitledRemarks { get; set; }
        public string? TitleStatus { get; set; }
        public string? TitleState { get; set; }
        public string? VehicleLocated { get; set; }
        public string? Reserve { get; set; }
        public decimal ReserveRemaks { get; set; }
        public string? AdInfoRemarks { get; set; }
        public int AuctionDuration { get; set; }
        public DateTime ApprovedDate { get; set; }
        //public string Images { get; set; }
        public string IsApproved { get; set; } = "0";
        public Guid AvId { get; set; }
        public List<VehicleImages>? VehicleImages { get; set; }
        public List<PlaceBid>? Bids { get; set; }
        public Guid? UserId { get; set; }
        public User? User { get; set; }
    }
}
