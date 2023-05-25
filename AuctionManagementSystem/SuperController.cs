using AMSModels;
using DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace AuctionManagementSystem
{
    public class SuperController : Controller
    {
        public bool IsLoggedIn { get; set; }
        public User CurrentUser { get; set; }
        //public Company CurrentCompany { get; set; }
        //public Employee CurrentEmployee { get; set; }
        private IUOW uow;
        public TypeOfUserEnum TypeOfUser { get; set; } = TypeOfUserEnum.NotLoggedIn;

        public SuperController(IHttpContextAccessor httpContextAccessor, IUOW _uow)
        {
            
            uow = _uow;
            var context = httpContextAccessor.HttpContext;
            if(!IsLoggedIn)
                Redirect("/Account/login");
            //var user = context.Session.GetString("UserId") != null;
            //if (user)
            //{
            //    CurrentUser = _uow.UserRepository().GetById(new Guid(context.Session.GetString("UserId")));
            //    if (CurrentUser == null)
            //    {
            //        Redirect("/Account/login");
            //        throw new Exception("Not Logged In");
            //    }
            //    TypeOfUser = TypeOfUserEnum.Admin;
            //}
   //         var company = context.Session.GetString("CompanyId") != null;
   //         if (company)
   //         {
   //             CurrentCompany = _uow.CompanyRepository().GetById(new Guid(context.Session.GetString("CompanyId")));
   //             if (CurrentCompany == null)
   //             {
   //                 Redirect("/Account/login");
   //                 throw new Exception("Not Logged In");
   //             }
   //             TypeOfUser = TypeOfUserEnum.Company;
   //         }
   //         var employee = context.Session.GetString("EmployeeId") != null;
   //         if (employee)
   //         {
   //             CurrentEmployee = _uow.EmployeeRepository().GetById(new Guid(context.Session.GetString("EmployeeId")));
   //             CurrentEmployee.Designation = _uow.DesignationRepository().GetById(CurrentEmployee.DesignationId);
   //             if (CurrentEmployee == null)
   //             {
   //                 Redirect("/Account/login");
   //                 throw new Exception("Not Logged In");
   //             }
   //             TypeOfUser = TypeOfUserEnum.Employee;
   //         }
			//if (CurrentEmployee == null&& CurrentCompany==null&& CurrentUser==null)
			//{
			//	Redirect("/Account/login");
			//}
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
