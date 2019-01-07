using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project_Burza.Data;
using Project_Burza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Burza.Controllers
{
    public class AccountController : Controller
    {

        protected UserManager<ApplicationUser> _userManager;
        protected ApplicationDbContext _context;


        public AccountController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            this._userManager = userManager;
            this._context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {

            var username = HttpContext.User.Identity.Name;
            var result = await _userManager.FindByNameAsync(username);



            return View(result);
        }


        [HttpGet]
        public IActionResult EditUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditUserAsync(UserModel model)
        {
            // Find user by its name
            var user = _userManager.FindByNameAsync(model.Email);

            //TODO: update record in database

            return RedirectToAction("Account");
        }


        [Authorize]
        [HttpGet]
        public IActionResult NewPost()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewPostAsync(TripModel model)
        {
            // TODO: Try to automatically pull the second tab with bunch of info about trips up

            if(ModelState.IsValid)
            {
                // Setting up authors name as name of the Logged in user
                model.AuthorName = HttpContext.User.Identity.Name;

                // Calculating nights based on difference of the dates
                // The "To" date is the ending date
                int nights = model.To.Date.Subtract(model.From.Date).Days;
                model.Nights = nights;

                if (String.IsNullOrEmpty(model.WebsiteLink))
                    model.WebsiteLink = "Žádná webová stránka není k dispozici";
                // Pull up the name of the picture
                // Upload it on a server side
                // Check if the picture is really formated in jpg / png
                model.ProfilePicturePath = "bla bla bla";

                _context.TripPosts.Add(model);
                await _context.SaveChangesAsync();
                
            }

            return RedirectToAction("Index");
        }


    }
}
