using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class CallController : Controller
    {
        // GET: CallController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CallController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CallController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CallController/Create
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

        // GET: CallController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CallController/Edit/5
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

        // GET: CallController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CallController/Delete/5
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
