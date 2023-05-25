using DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuctionManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        private IHttpContextAccessor httpContextAccessor;
        private IUOW UOW;
        private readonly IWebHostEnvironment webHostEnvironment;
        public AccountController(IHttpContextAccessor httpContext, IUOW _uow, IWebHostEnvironment _webHostEnvironment) : base()
        {
            httpContextAccessor = httpContext;
            UOW = _uow;
            webHostEnvironment = _webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PostLogin(string UserName, string password)
        {
            TempData["email"] = UserName;
            TempData["password"] = password;
            Dictionary<Guid, string> dic = UOW.Authentication(UserName, password);
            if (dic.Count <= 0)
                AlertMessage("Invalid email or password.", AlertType.Error);
            //if (dic.ContainsValue(TypeOfUserEnum.Admin.ToString()))
            //{
            //    User user = UOW.UserRepository().GetById(new Guid(dic.Keys.FirstOrDefault().ToString()));
            //    httpContextAccessor.HttpContext.Session.SetString("UserId", Convert.ToString(user.Id));
            //}
            //if (dic.ContainsValue(TypeOfUserEnum.Company.ToString()))
            //{
            //    Company company = UOW.CompanyRepository().GetById(new Guid(dic.Keys.FirstOrDefault().ToString()));
            //    if (company.IsApproved == 0)
            //    {
            //        AlertMessage("Your company is not approved.", AlertType.REGULAR);
            //    }
            //    else
            //    {
            //        httpContextAccessor.HttpContext.Session.SetString("CompanyId", Convert.ToString(company.CompanyId));
            //    }
            //}
            //if (dic.ContainsValue(TypeOfUserEnum.Employee.ToString()))
            //{
            //    Employee employee = UOW.EmployeeRepository().GetById(new Guid(dic.Keys.FirstOrDefault().ToString()));
            //    if (employee.IsActive == 0)
            //    {
            //        AlertMessage("Your account is not activate anymore.", AlertType.Error);
            //    }
            //    else
            //    {
            //        httpContextAccessor.HttpContext.Session.SetString("EmployeeId", Convert.ToString(employee.Id));
            //    }
            //}

            return RedirectToAction("Index", "Home");
        }
        public IActionResult register()
        {
            return View();
        }
        public void AlertMessage(string message, AlertType alertType = AlertType.REGULAR)
        {
            TempData["AlertMessage"] = message;
            TempData["AlertType"] = alertType;
            TempData["IsAlert"] = 1;
        }

        public enum AlertType
        {
            REGULAR = 1,
            Error = 2,
            SUCCESS = 3
        }
        public enum TypeOfUserEnum
        {
            NotLoggedIn = 0,
            Admin = 1,
            Company = 2,
            Employee = 3
        }
    }
}
