using BlogSite.Models;
using BlogSite.Models.MVVM;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Threading.Tasks;



namespace BlogSite.Controllers
{
    public class AuthController : Controller
    {
        SignInManager<IdentityUser> _signInManager;
        UserManager<IdentityUser> _userManager;
        public AuthController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Register() => View();


        [HttpPost]
        public IActionResult Register(RegisterViewModel vm)
        {
            var adminUser = new IdentityUser { UserName = vm.UserName, Email = vm.Email };
            var result =_userManager.CreateAsync(adminUser, vm.Password).GetAwaiter().GetResult();

            if (result.Succeeded)
            {
                
                _signInManager.SignInAsync(adminUser, false);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var reuslt =await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

            if(!reuslt.Succeeded)
            {
                return View(model);


                
            }
            //var user = HttpContext.User;
            //var isAdmin = user.IsInRole("Admin");
            var _user = await _userManager.FindByNameAsync(model.UserName);
           var isadmin = await _userManager.IsInRoleAsync(_user, "Admin");
            
            if(isadmin)
                return RedirectToAction("Index", "Panel");

            return RedirectToAction("Index", "Home");

        }


        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
