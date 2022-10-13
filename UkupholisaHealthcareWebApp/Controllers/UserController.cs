using Microsoft.AspNetCore.Mvc;
using UkupholisaHealthcare.Library.Data;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserData _userData;

        public UserController(IUserData userData)
        {
            _userData = userData;
        }
        public IActionResult Index()
        {
            var users = _userData.GetAllUsers();
            return View(users);
        }
    }
}
