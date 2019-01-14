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
            if (ViewData["DetailsInt"] == null)
                ViewData["DetailsInt"] = 0;

            List<TripViewModel> model = new List<TripViewModel>();

            for (int i = _context.TripPosts.Count() - 1; i >= 0; i--)
            {
                TripViewModel tripMod = new TripViewModel();
                tripMod.TripModel = _context.TripPosts.ToList()[i];
            
                string authorName = _context.TripPosts.ToList()[i].AuthorName;

                var user = await _userManager.FindByNameAsync(authorName);

                tripMod.PhoneNumber = await _userManager.GetPhoneNumberAsync(user);
                tripMod.NameAndSurname = user.NameAndSurname;


                model.Add(tripMod);


            }            

            return View(model);
        }


        public IActionResult ShowTripInfo(int id)
        {
            var model = _context.TripPosts.Where(x => x.Id == id).FirstOrDefault();

            return PartialView("_TripInfoModalPartial", model);
        }

        public IActionResult ShowTripBuyInfo(int id)
        {
            var model = _context.TripPosts.Where(x => x.Id == id).FirstOrDefault();

            return PartialView("_TripInfoBuyModalPartial", model);
        }
    }
}