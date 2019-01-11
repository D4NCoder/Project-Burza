using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project_Burza.Data;
using Project_Burza.Models;

namespace Project_Burza.Controllers
{
    public class TripController : Controller
    {
        protected ApplicationDbContext  _context;

        protected UserManager<ApplicationUser> _userManager;


        public TripController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            this._context = context;
            this._userManager = userManager;
        }

        public async Task<IActionResult> Trips()
        {

            List<TripViewModel> model = new List<TripViewModel>();

            for (int i = _context.TripPosts.Count() - 1; i >= 0; i--)
            {
                TripViewModel tripMod = new TripViewModel();
                tripMod.TripModel = _context.TripPosts.ToList()[i];
            
                string authorName = _context.TripPosts.ToList()[i].AuthorName;

                tripMod.PhoneNumber = await _userManager.GetPhoneNumberAsync(await _userManager.FindByNameAsync(authorName));

                model.Add(tripMod);


            }            

            return View(model);
        }

        public async Task<FileResult> GetPictureFromDatabase(byte[] image)
        {

            byte[] pic = image;

            return File(pic, "image/png");
        }

        public async Task<FileResult> GetProfilePictureFromDatabase()
        {
            var username = HttpContext.User.Identity.Name;

            var user = await _userManager.FindByNameAsync(username);

            byte[] pic = user.ProfilePicture;

            return File(pic, "image/png");
        }
    }
}