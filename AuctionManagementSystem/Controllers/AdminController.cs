using AMSModels;
using AspNetCoreHero.ToastNotification.Abstractions;
using DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuctionManagementSystem.Controllers
{
    //[Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private IUOW UOW;
        private readonly INotyfService _notyf;
        public AdminController(IUOW uOW, INotyfService notyfService)
        {
            UOW = uOW;
            _notyf = notyfService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllUsers()
        {
            List<User> users = UOW.UserRepository().GetAll().ToList();
            return View(users);
        }
        public IActionResult GetAllVehicles()
        {
            List<AddVehicle> list=UOW.AddVehicle().GetAll().ToList();
            return View(list);
        }
        public IActionResult GetVehicleDetails(Guid Id)
        {
            AddVehicle vehicle=UOW.AddVehicle().GetAll().Where(x=>x.AvId==Id).Include(x=>x.VehicleImages).FirstOrDefault();
            return View("Details",vehicle);
        }
        public IActionResult ApproveVehicle(Guid Id)
        {
            AddVehicle vehicle=UOW.AddVehicle().GetById(Id);
            vehicle.IsApproved = "1";
            vehicle.ApprovedDate = DateTime.Now;
            vehicle.AuctionDuration = UOW.Configurations().GetAll().FirstOrDefault().AuctionDuration;
            UOW.AddVehicle().Update(vehicle);
            UOW.Save();
            return RedirectToAction("GetAllVehicles");
        }
        //public IActionResult AllContacts(Guid Id)
        //{
        //    List<ContactMe> contacts=UOW.ContactMe.GetAll();
        //    vehicle.IsApproved = "1";
        //    UOW.AddVehicle().Update(vehicle);
        //    UOW.Save();
        //    return RedirectToAction("GetAllVehicles");
        //}
        public IActionResult Configurations()
        {
            var config = UOW.Configurations().GetAll().FirstOrDefault();
            return View(config);
        }
        [HttpPost]
        public IActionResult Configurations(Configuration config)
        {
            if (ModelState.IsValid)
            {
                UOW.Configurations().Update(config);
                UOW.Save();
                return RedirectToAction("Configurations");
            }
            return View(config);
        }
    }
}
