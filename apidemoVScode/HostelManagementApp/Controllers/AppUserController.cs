using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HostelManagementApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HostelManagementApp.Controllers
{
    public class AppUserController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<AppUser> {
             new AppUser {AppUserId=1, Name="Zeeshan asghar", DOB=DateTime.Now.AddYears(-40), Email="z@tttt.com" },
             new AppUser {AppUserId=2, Name="Riz khan", DOB=DateTime.Now.AddYears(-35), Email="riz@tttt.com" },
            };

            return View(model);
        }

        public IActionResult ViewDetails ()
        {
            return View();
        }
    }
}
