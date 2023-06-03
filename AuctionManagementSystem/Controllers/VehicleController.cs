using AMSModels;
using AspNetCoreHero.ToastNotification.Abstractions;
using DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;

namespace AuctionManagementSystem.Controllers
{
    public class VehicleController : SuperController
    {
        private IHttpContextAccessor httpContextAccessor;
        private IUOW UOW;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly INotyfService _notyf;
        public VehicleController(IHttpContextAccessor httpContext, IUOW _uow, IWebHostEnvironment _webHostEnvironment, INotyfService notyf) : base(httpContext, _uow)
        {
            httpContextAccessor = httpContext;
            UOW = _uow;
            webHostEnvironment = _webHostEnvironment;
            _notyf = notyf;
        }
        public IActionResult vehiclesubmission()
        {
           
            AddVehicleView addVehicle = new AddVehicleView();
            return View(addVehicle);
        }
        [HttpPost]
        public IActionResult vehiclesubmission(AddVehicleView ad)
        {
            //TempData["pesan"] = "Data Berhasil disimpan...";
            if (ModelState.IsValid)
            {
                AddVehicle advv = new AddVehicle();
                if (ad.Images == null || ad.Images.Length == 0)
                {
                    // Handle empty or invalid file
                    return BadRequest("Invalid file");
                }
                int a = 5;
                Guid guid = new Guid();
                string Id = guid.ToString();
                advv = new()
                {
                    AvId = guid,
                    FullName = ad.FullName,
                    Year = ad.Year,
                    Make = ad.Make,
                    Model = ad.Model,
                    VIN = ad.VIN,
                    COR = ad.COR,
                    CORType = ad.CORType,
                    //  odometerreadingreflect = ad.odometerreadingreflect,
                    OORMilegeRemarks = ad.OORMilegeRemarks,
                    VehiclePurchaseMoth = ad.VehiclePurchaseMoth,
                    VehiclePurchaseYear = ad.VehiclePurchaseYear,
                    Vmiles = ad.Vmiles,
                    mileageDistanceUnit = ad.mileageDistanceUnit,
                    VownershipRemarks = ad.VownershipRemarks,
                    Vaccident = ad.Vaccident,
                    VaccidentRemarks = ad.VaccidentRemarks,
                    VDamage = ad.VDamage,
                    VehicleLocated = ad.VehicleLocated,
                    VSeller = ad.VSeller,
                    DealerName = ad.DealerName,
                    OwnerDetails = ad.OwnerDetails,
                    Vtitled = ad.Vtitled,
                    VtitledRemarks = ad.VtitledRemarks,
                    TitleStatus = ad.TitleStatus,
                    TitleState = ad.TitleStatus,
                    Reserve = ad.Reserve,
                    ReserveRemaks = ad.ReserveRemaks,
                    AdInfoRemarks = ad.AdInfoRemarks,
                    VehicleOwnerShipHistory = ad.VehicleOwnerShipHistory,
                    IsApproved = "0"
                };
                UOW.AddVehicle().Insert(advv);
                UOW.Save();
                foreach (var imageFile in ad.Images)
                {
                    if (imageFile.Length > 0)
                    {
                        // Process each image file
                        // Example: Save the file to a specific location
                        string wwwRootPath = webHostEnvironment.WebRootPath;
                        string NewGuid = "";
                        NewGuid = Guid.NewGuid().ToString();
                        var filePath = Path.Combine(wwwRootPath + "/media/", NewGuid + "_" + imageFile.FileName);// Path.Combine(Directory.GetCurrentDirectory(), "Images", Guid.NewGuid().ToString() + "_" + imageFile.FileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            imageFile.CopyTo(stream);
                            VehicleImages vi = new()
                            {
                                ImagePath = "~/media/"+ NewGuid + "_" + imageFile.FileName,
                                AddVehicleId = advv.AvId
                            };
                            UOW.AddVehicleImage().Insert(vi);
                            UOW.Save();
                        }
                    }
                }
                TempData["pesan"] = " Forward For Approval";
                _notyf.Custom("Request Save Scussfully.", 10, "#B600FF", "fa fa-home");
                return View(new AddVehicleView());
            }

            var errors = ModelState.Values.SelectMany(x => x.Errors).ToArray();
            _notyf.Custom(errors.ToString(), 10, "#B600FF", "fa fa-home");
            return View(ad);
        }
        public IActionResult VehicleAuction()
        {
            List<AddVehicleView> ad = UOW.GetVehicleInFo();
            TempData["employee"] = UOW.GetPendingVehicleInfo(); 
            return View(ad);
        }
        public IActionResult AuctionDetails(Guid AvId)
        {

            AddVehicle vehicle = UOW.AddVehicle().GetById(AvId);
            vehicle.VehicleImages=UOW.AddVehicleImage().GetAll().Where(x=>x.AddVehicleId==AvId).ToList();
            return View(vehicle);
        }
        [HttpPost]
        public IActionResult SaveBid(string PostId,string amount)
        {
            if (PostId == "")
            {
                return Json(-1);
            }
            else
            {
                Guid guid = new Guid();
                PlaceBid placebid = new PlaceBid()
                {
                    Id = guid,
                    BidAmount = amount,
                    BidTime = DateTime.Now,
                    Userid = "Super Admin",
                    BidId = PostId,
                }
                ;
                UOW.AddBid().Insert(placebid);
                UOW.Save();
                return Json(1);
            }    
        }
    }
}
