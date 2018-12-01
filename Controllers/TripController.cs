using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Project_Burza.Controllers
{
    public class TripController : Controller
    {
        public IActionResult Trips()
        {
            return View();
        }
    }
}