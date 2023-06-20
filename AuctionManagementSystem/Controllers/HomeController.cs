using AMSModels;
using AuctionManagementSystem.Models;
using DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Net.Mail;

namespace AuctionManagementSystem.Controllers
{
	public class HomeController : Controller
	{
        private readonly IUOW UOW;
        public HomeController( IUOW _uow)
		{
		
            UOW = _uow;
        }

		public IActionResult Index()
		{
            //HttpContextAccessor.HttpContext.session["Succesmsg"];
            List<AddVehicle> approvedVehicles = UOW.AddVehicle().GetAll().Include(x=>x.Bids).Include(x => x.VehicleImages).ToList();
            return View(approvedVehicles);
		}
		public IActionResult Contact()
		{

            return View();
        }
        public IActionResult About()
        {
            List<User> ApprvdUsers = UOW.UserRepository().GetAll().Where(x => x.IsApproved == 1).ToList();  //AddVehicle().GetAll().Include(x => x.VehicleImages).ToList();
            return View(ApprvdUsers);
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
               UOW.ContactMe(name, email,message);
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