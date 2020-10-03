using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data;
using Microsoft.AspNetCore.Mvc;

namespace DrinkAndGo.Controllers
{
    public class DrinkController : Controller
    {
        IDrinkRepository _drink;
        ICategoryRepository _category;

        public DrinkController(IDrinkRepository drink, ICategoryRepository category)
        {
            _drink = drink;
            _category = category;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public ViewResult List()
        {

        }
    }
}
