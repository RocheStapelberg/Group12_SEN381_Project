using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using UkupholisaHealthcare.Library.Data;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserData _userData;

        public LoginController(IUserData userData)
        {
            _userData = userData;
        }

        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePage()
        {
            return View();
        }

        public IActionResult Create(User user, string password)
        {
            byte[] source = Encoding.ASCII.GetBytes(password);
            byte[] hash = MD5.Create().ComputeHash(source);

            user.Password = hash;

            _userData.InsertUser(user);

            return RedirectToAction("Index");
        }

        public ActionResult Login(string email, string password)
        {
            List<User> users = new List<User>();

            users = _userData.GetUserByEmail(email);

            if (users.Count == 0)
            {
                return RedirectToAction("LoginFailed");
            }

            // Password validation
            byte[] source = Encoding.ASCII.GetBytes(password);
            byte[] hash = MD5.Create().ComputeHash(source);

            byte[] databaseHash = users[0].Password;

            if (hash.Length == databaseHash.Length)
            {
                int i = 0;
                while ((i < hash.Length) && (hash[i] == databaseHash[i]))
                {
                    i++;
                }
                if (i == hash.Length)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    return RedirectToAction("LoginFailed");
                }
            }

            return RedirectToAction("LoginFailed");
        }

        public ActionResult LoginFailed()
        {
            return View();
        }
    }
}
