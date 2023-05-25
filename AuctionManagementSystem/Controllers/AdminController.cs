using Microsoft.AspNetCore.Mvc;

namespace AuctionManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
