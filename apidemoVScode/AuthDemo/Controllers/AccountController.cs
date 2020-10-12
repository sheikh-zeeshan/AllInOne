using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthDemo.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthDemo.Controllers
{
    
    public class AccountController : Controller
    {
        IUserRepository _userRepo;

     
        public AccountController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login(string returnurl = "/")
        {
            return View(new LoginModel { ReturnUrl= returnurl });
        }

        [HttpPost]
        public IActionResult Login(LoginModel md)
        {
            return View();
        }

    }
}
