using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project_Burza.Data;
using Project_Burza.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Project_Burza.Controllers
{
    public class LoginController : Controller
    {
        protected UserManager<ApplicationUser> _userManager;
        protected SignInManager<ApplicationUser> _signInManager;
        protected ApplicationDbContext _context;

        private IHostingEnvironment _env;

        public LoginController(UserManager<ApplicationUser> userManager, ApplicationDbContext context, SignInManager<ApplicationUser> signInManager, IHostingEnvironment env)
        {
            this._userManager = userManager;
            this._context = context;
            this._signInManager = signInManager;
            this._env = env;
        }

        public IActionResult Login()
        {
            // This is making sure that our database exists
            _context.Database.EnsureCreated();

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> LogInUserAsync(string email, string password, bool remember)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, remember, true);
 
            var reslt = result.Succeeded;
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Account");
            }

            return Redirect(@Url.Action("Login", "Login"));
        }


        public async Task<IActionResult> CreateAccountAsync(UserModel model)
        {
            var webRoot = _env.WebRootPath;
            var path = webRoot + "/ProfilePic/ProfileAvatar.png";

            var photo = System.IO.File.ReadAllBytes(path);

            // Making sure that passwords match together and that user agrees with terms
            if (model.Password == model.PasswordAgain && model.UserAgreement == true)
            {
                var apUser = new ApplicationUser
                {
                    Email = model.Email,
                    NameAndSurname = model.NameAndSurname,
                    PhoneNumber = model.PhoneNumber,
                    UserName = model.Email,
                    ProfilePicture = photo                  

                };

                var result = await _userManager.CreateAsync(apUser, model.Password);



                if (result.Succeeded)
                {
                    // TODO: redirect to sign in page
                    return RedirectToAction("Login", "Login");
                }
                
            }

            // Otherwise return back to login
            // feature: use View(model) to input model so it will be easier for user to know what he needs to do again
            return RedirectToAction("Register");
        }
        
        public async Task<IActionResult> LogOutUserAsync()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}