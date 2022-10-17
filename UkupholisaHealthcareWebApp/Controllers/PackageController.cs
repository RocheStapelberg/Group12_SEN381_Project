using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class PackageController : Controller
    {
        // GET: PackageController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PackageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PackageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PackageController/Create
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

        // GET: PackageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PackageController/Edit/5
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

        // GET: PackageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PackageController/Delete/5
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
