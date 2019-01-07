using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project_Burza.Models;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using ProjectBurza.Models;
    
namespace Project_Burza.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EmailSent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail(EmailModel model)
        {

            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("HolidexSupport", "holexchange@gmail.com"));
            message.To.Add(new MailboxAddress("holidex company", "holexchange@gmail.com"));
            message.Subject = model.Subject;
            message.Body = new TextPart("plain")
            {
                Text = "Uživatel: " + model.FromName + "\nE-mail: " + model.FromAdress + "\n\n" + model.Body
            };

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect("smtp.gmail.com", 587, false);
                // TODO: Bring those values into appsettings.json
                client.Authenticate("holexchange@gmail.com", "Holidex123*");
                client.Send(message);
                client.Disconnect(true);
            }

            return RedirectToAction("EmailSent");
        }

        public IActionResult Tutorial(){
            return View();
        }

        public IActionResult LawSecurity()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
