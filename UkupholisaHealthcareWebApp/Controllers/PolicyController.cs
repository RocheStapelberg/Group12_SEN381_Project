using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class PolicyController : Controller
    {
        // GET: PolicyController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PolicyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PolicyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PolicyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PolicyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PolicyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PolicyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PolicyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
