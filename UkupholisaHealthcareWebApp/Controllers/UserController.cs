using Microsoft.AspNetCore.Mvc;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
