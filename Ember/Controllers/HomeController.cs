using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ember.Models;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;


namespace Ember.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Emberlabs";
            ViewBag.Tagline = "We are IT consultants who specialize in supporting small businesses. Nice to meet you!";
            return View();
        }

        [HttpPost]
        public ActionResult Index(Ember.Models.Contact contact)
        {
            //if (ModelState.IsValid)
            //{
            //    //send a message
            //    MailMessage msg = new MailMessage(contact.Email, "shambles72@hotmail.com", "You are cool", "You are really cool");

            //    SmtpClient smtpClient = new SmtpClient("smtp.sendgrid.net", Convert.ToInt32(587));
            //    System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("username@domain.com", "yourpassword");
            //    smtpClient.Credentials = credentials;

            //    smtpClient.Send(mailMsg);
            //}
           
            return View(contact);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}