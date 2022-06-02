using EvaShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoWebApp.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IEmailSender _emailSender;
        private const string SessionKeyName = "_Name";
        private const string Error = "_Error";

        public ManagerController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string user, string password)
        {
            if (user == "Admin" && password == "Catolica10")
            {
                HttpContext.Session.SetString(SessionKeyName, "Admin");
                return Redirect("/Inventarios");
            }
            HttpContext.Session.SetString(Error,"Usuario o contraseña incorrecta");
            return Redirect("/Home");

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SessionKeyName);
            HttpContext.Session.Remove(Error);
            return Redirect("/Home");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Newsletter(string email)
        {
            const string msg = "<h1 style='text-align: center'>Felicidades tienes un descuento del 20%<h1>";
            return Redirect(_emailSender.Notify(msg, email) ? "/Home" : "/Contact");
        }

        //GET IN TOUCH
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetInTouch(string name,string email, string subject, string body)
        {
            var msg = email + ": " + body; 
            return Redirect(_emailSender.Notify(msg,_emailSender.GetEmail(),subject) ? "/Home" : "/Contact");
        }
    }
}
