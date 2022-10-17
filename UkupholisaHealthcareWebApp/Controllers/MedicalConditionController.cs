using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class MedicalConditionController : Controller
    {
        // GET: MedicalConditionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MedicalConditionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MedicalConditionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicalConditionController/Create
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

        // GET: MedicalConditionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MedicalConditionController/Edit/5
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

        // GET: MedicalConditionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MedicalConditionController/Delete/5
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
