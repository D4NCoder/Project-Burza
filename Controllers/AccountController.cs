using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Burza.Data;
using Project_Burza.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Burza.Controllers
{
    public class AccountController : Controller
    {
        protected SignInManager<ApplicationUser> _singInManager;
        protected UserManager<ApplicationUser> _userManager;
        protected ApplicationDbContext _context;


        public AccountController(UserManager<ApplicationUser> userManager, ApplicationDbContext context, SignInManager<ApplicationUser> singInManager)
        {
            this._userManager = userManager;
            this._context = context;
            this._singInManager = singInManager;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {

            var username = HttpContext.User.Identity.Name;
            var result = await _userManager.FindByNameAsync(username);

            AccountModel model = new AccountModel();
            model.User = result;
            model.TripPosts = _context.TripPosts.Where(x => x.AuthorName == model.User.Email).ToList();

            if (model.User.ProfilePicture == null)
                ViewData["isProfilePicture"] = false;
            else
                ViewData["isProfilePicture"] = true;


            return View(model);
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> EditUser(UserModel model)
        {   
            var username = HttpContext.User.Identity.Name;
            var result = await _userManager.FindByNameAsync(username);

            var result2 = (!string.IsNullOrEmpty(model.NameAndSurname)) ? model : new UserModel
            {
                Id = result.Id,
                NameAndSurname = result.NameAndSurname,
                Email = result.Email,
                Password = "",
                PasswordAgain = "",
                PhoneNumber = result.PhoneNumber,
                UserAgreement = true,
                ProfilePicture = result.ProfilePicture
            };

            if (result2.ProfilePicture == null)
                ViewData["isProfilePicture"] = false;

            return View(result2);
        }

        [HttpPost]
        public async Task<IActionResult> EditUserAsync([FromForm]UserModel model, string oldName, IFormFile file)
        {

                // Find user by its name
                var user = await _userManager.FindByNameAsync($"{oldName}");
    
                //TODO: Add profile picture path loading to database
                user.NameAndSurname = model.NameAndSurname;
                user.Email = model.Email;
                user.UserName = model.Email;
                user.NameAndSurname = model.NameAndSurname;
                user.PhoneNumber = model.PhoneNumber;
                if(file != null)
                    user.ProfilePicture = await PutPictureToDatabase(file);
                if(!string.IsNullOrEmpty(model.Password))
                    if(model.Password == model.PasswordAgain)
                        user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
                    // TODO: Redirect user to the same view with writen validation issues out

                var result = await _userManager.UpdateAsync(user);
                await _singInManager.RefreshSignInAsync(user);

            if (result.Succeeded)
                    return RedirectToAction("Index");
            
            


            return RedirectToAction("EditUser", new { model });
        }


        [Authorize]
        [HttpGet]
        public IActionResult NewPost()
        {
            return View();
        }


        // TODO: DELETE User --> Adding new method / function for that purpose
        public async Task<IActionResult> DeletePost(int idP)
        {
            // TODO: Implement Id feature to html code, so the script below can pull it from the atribute or something of specific html part
            var entity = _context.TripPosts.Where(b => EF.Property<int>(b, "Id") == idP);
            
            foreach(var ent in entity)
                _context.TripPosts.Remove(ent);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public async Task<IActionResult> AddNewPostAsync(TripModel model, IFormFile file)
        {
            // TODO: Try to automatically pull the second tab with bunch of info about trips up

            if(ModelState.IsValid)
            {
                //Setting up authors name as name of the Logged in user
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
                model.TripPicture = await PutPictureToDatabase(file);

                _context.TripPosts.Add(model);
                await _context.SaveChangesAsync();

            }

            return RedirectToAction("Index");
        }

        public async Task<byte[]> PutPictureToDatabase(IFormFile model)
        {
            using (var memoryStream = new MemoryStream())
            {
                await model.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }

    }
}
