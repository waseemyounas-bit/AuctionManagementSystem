using AMSModels;
using AspNetCoreHero.ToastNotification.Abstractions;
using DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace AuctionManagementSystem.Controllers
{
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
            List<AddVehicleView> list=UOW.AddVehicle().GetAll().ToList();
            return View(list);
        }
        public IActionResult GetVehicleDetails(Guid Id)
        {
            AddVehicleView vehicle=UOW.AddVehicle().GetById(Id);
            return View(vehicle);
        }
    }
}
