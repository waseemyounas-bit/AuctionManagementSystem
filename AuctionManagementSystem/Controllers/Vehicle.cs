using AMSModels;
using Microsoft.AspNetCore.Mvc;

namespace AuctionManagementSystem.Controllers
{
    public class Vehicle : Controller
    {
        public IActionResult vehiclesubmission()
        {
            AddVehicle addVehicle = new AddVehicle();
            return View(addVehicle);
        }
        [HttpPost]
        public IActionResult vehiclesubmission(AddVehicle ad)
        {
            AddVehicle addVehicle = new AddVehicle();
            return View(addVehicle);
        }
    }
}
