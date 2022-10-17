using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using UkupholisaHealthcare.Library.BussinessLogic;
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
            // Encode string to ASCII byte array
            byte[] source = Encoding.ASCII.GetBytes(password);
            // Hash byte array with MD5 and store in byte array
            byte[] hash = MD5.Create().ComputeHash(source);

            // Store database user's hash in a byte array
            byte[] databaseHash = users[0].Password;

            // Compare hash lengths
            if (hash.Length == databaseHash.Length)
            {
                // Compare each index in byte arrays
                int i = 0;
                while ((i < hash.Length) && (hash[i] == databaseHash[i]))
                {
                    i++;
                }
                if (i == hash.Length)
                {
                    // Redirect to Dashboard if successfull
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
