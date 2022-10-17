using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class CallReportController : Controller
    {
        // GET: CallReportController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CallReportController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CallReportController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CallReportController/Create
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

        // GET: CallReportController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CallReportController/Edit/5
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

        // GET: CallReportController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CallReportController/Delete/5
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
