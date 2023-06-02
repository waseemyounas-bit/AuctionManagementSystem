using AMSModels;
using AuctionManagementSystem.Models;
using DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
            return View();
		}
		public IActionResult Contact()
		{
            return View();
        }
        [HttpPost]
        public IActionResult Contact(string name, string message, string email)
        {
            if (name == "" || name==null)
            {
                return Json(-1);
            }
            else
            {
                UOW.ContactMe(name, message, email);
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