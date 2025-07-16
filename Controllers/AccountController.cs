using EE_Commerce.Models;
using EEcomercEE.Datas;
using EEcomercEE.Models.entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EEcomercEE.Controllers
{
    public class AccountController : Controller
    {
        AppDbContext context = new AppDbContext();
       
        public UserManager<ApplicationUser> UserManager { get; }
        public SignInManager<ApplicationUser> SignInManager { get; }

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public IActionResult index()
        {
            var products = context.Products.ToList();

            return View("index", products);

        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View("SignUp");
        }
        [HttpPost]
        public async Task<IActionResult> SaveSignUp(SignupViewModel user)
        {
           
           
            if (ModelState.IsValid)
            {
                ApplicationUser appuser = new ApplicationUser();
                appuser.Email = user.Email;
                appuser.FirstName = user.FirstName;
                appuser.PasswordHash = user.Password;
                appuser.UserName = user.Email;
                //save database
                IdentityResult result = await UserManager.CreateAsync(appuser,user.Password);
                if (result.Succeeded)
                {

                   await SignInManager.SignInAsync(appuser,false);
                    return RedirectToAction("Index");
                }
                foreach(var i in result.Errors)
                {
                    ModelState.AddModelError("",i.Description);
                }
            }
            return View("signup", user);
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            return View("LogIn");
        }
        [HttpPost]
        public async Task<IActionResult> SaveLogin(LoginViewModel dataFromRequest)
        {
            if (ModelState.IsValid)
            {
                //get from db ,compare ,authanticated
                ApplicationUser user = await UserManager.FindByEmailAsync(dataFromRequest.Email);
                if (user != null)
                {
                    bool found = await UserManager.CheckPasswordAsync(user, dataFromRequest.Password);
                    if (found)
                    {
                        await SignInManager.SignInAsync(user, dataFromRequest.rememberme);
                    }

                }
                return RedirectToAction("index");

            }
            return View("login", dataFromRequest);
        }
        public async Task<IActionResult> SignOut()
        {
            await SignInManager.SignOutAsync();
            return View("Login");
        }

    }
   
}
