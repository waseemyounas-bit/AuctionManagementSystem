using AMSModels;
using AspNetCoreHero.ToastNotification.Abstractions;
using DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;

namespace AuctionManagementSystem.Controllers
{
    public class Vehicle : SuperController
    {
        private IHttpContextAccessor httpContextAccessor;
        private IUOW UOW;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly INotyfService _notyf;
        public Vehicle(IHttpContextAccessor httpContext, IUOW _uow, IWebHostEnvironment _webHostEnvironment, INotyfService notyf) : base(httpContext, _uow)
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
        public IActionResult vehiclesubmission(AddVehicle ad)
        {
            if (ad.Images == null || ad.Images.Length == 0)
            {
                // Handle empty or invalid file
                return BadRequest("Invalid file");
            }
       
            // Process the image file
            // Example: Save the file to a specific location
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Images", Guid.NewGuid().ToString() + "_" + ad.Images.FileName);
            ad.ImagePath = filePath;
            System.IO.File.Create(filePath).Dispose();
            AddVehicleView advv = new AddVehicleView();
            //adView.ImagePath = filePath;
            //string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(ad.Images.FileName);
            string extension = Path.GetExtension(ad.Images.FileName);
            if (ModelState.IsValid)
            {
                 advv = new()
                {
                    Id=ad.Id,
                    FullName = ad.FullName,
                    Year = ad.Year,
                    Make = ad.Make,
                    Model = ad.Model,
                    VIN = ad.VIN,
                    COR = ad.COR,
                    CORType = ad.CORType,
                    odometerreadingreflect = ad.odometerreadingreflect,
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
                    ImagePath = filePath
                };
                UOW.AddVehicle().Insert(advv);
                //Delete that post
                //UOW.UserRepository().Update(us);

                //Commit the transaction
                UOW.Save();
                _notyf.Custom("Request Save Scussfully.", 10, "#B600FF", "fa fa-home");
                return RedirectToAction("Index", "Home");
            }
            return View(advv);
        }
    }
}
