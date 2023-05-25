﻿using DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using AMSModels;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.Extensions.Hosting;

namespace AuctionManagementSystem.Controllers
{
    public class AccountController : SuperController
    {
        private IHttpContextAccessor httpContextAccessor;
        private IUOW UOW;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly INotyfService _notyf;
        public AccountController(IHttpContextAccessor httpContext, IUOW _uow, IWebHostEnvironment _webHostEnvironment, INotyfService notyf) : base(httpContext, _uow)
        {
            httpContextAccessor = httpContext;
            UOW = _uow;
            webHostEnvironment = _webHostEnvironment;
            _notyf = notyf;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            User user = new User();
            return View(user);
        }
        [HttpPost]
        public IActionResult PostLogin(string UserName, string password)
        {
            if (ModelState.IsValid)
            {
                if (UserName == "" || UserName == null)
                {
                    _notyf.Custom("Invalid email or password.", 10, "#B600FF", "fa fa-home");
                    return RedirectToAction("Login", "Account");
                }
                TempData["UserName"] = UserName;
                TempData["password"] = password;
                User user = UOW.Authentication(UserName, password);
                if (user != null)
                {
                    //Dictionary<Guid, user> dic= UOW.Authentication(UserName, password);
                    if (user.ToString().Count() <= 0 && user.ToString().Count() != null)
                    {
                        var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, user.FullName, ClaimTypes.Role, "Admin") }, CookieAuthenticationDefaults.AuthenticationScheme);
                        if (user.RoleId == 1)
                        {
                            identity.AddClaim(new Claim(ClaimsIdentity.DefaultRoleClaimType, "Admin", ClaimValueTypes.String));
                        }
                        else
                        {
                            identity.AddClaim(new Claim(ClaimsIdentity.DefaultRoleClaimType, "User", ClaimValueTypes.String));
                        }
                        var principle = new ClaimsPrincipal(identity);
                        //Roles.Add(principle);
                        var claims = principle.Claims;
                        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principle);
                        return RedirectToAction("Index", "Home");
                    }
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    _notyf.Custom("Invalid email or password.", 10, "#B600FF", "fa fa-home");
                    AlertMessage("Invalid email or password.", AlertType.Error);
                    return RedirectToAction("Login", "Account");
                }
            }
            return RedirectToAction("Login", "Account");
        }
        public IActionResult Register()
        {
            User user = new User();
            return View(user);
        }
        public IActionResult RegisterUser(User us)
        {
            if (ModelState.IsValid)
            {
                _notyf.Custom("Invalid email or password.", 10, "#B600FF", "fa fa-home");
            }
                return View(us);
        }
        [HttpPost]
        public IActionResult Register(User us)
        {
            if (ModelState.IsValid)
            {
                us.IsApproved = 0;
                    UOW.UserRepository().Insert(us);
                    //Delete that post
                    //UOW.UserRepository().Update(us);

                    //Commit the transaction
                    UOW.Save();
                _notyf.Custom("Request Save Scussfully.", 10, "#B600FF", "fa fa-home");
                _notyf.Custom("Request Send For Approval.", 10, "#B600FF", "fa fa-home");
                return RedirectToAction("Index", "Home");
            }
            return View(us);
        }
    }
}
