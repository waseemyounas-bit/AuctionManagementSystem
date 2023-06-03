using AMSModels;
using AuctionManagementSystem.Models;
using DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;

namespace AuctionManagementSystem.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private IUOW UOW;
        public HomeController(ILogger<HomeController> logger, IUOW _uow)
		{
			_logger = logger;
            UOW = _uow;
        }

		public IActionResult Index()
		{
            //HttpContextAccessor.HttpContext.session["Succesmsg"];
            List<AddVehicleView> ad = UOW.GetVehicleInFo();
            TempData["employee"] = UOW.GetPendingVehicleInfo();
            return View(ad);
		}
		public IActionResult Contact()
		{
            return View();
        }
        [HttpPost]
        public IActionResult Contact(string name, string email, string message)
        {
            if (name == "" || name==null)
            {
                return Json(-1);
            }
            else
            {
               int i= UOW.ContactMe(name, email,message);
                return Json(1);
            }
        }
   
    public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}