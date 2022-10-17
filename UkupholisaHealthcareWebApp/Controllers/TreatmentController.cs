using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UkupholisaHealthcare.Library.BussinessLogic;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class TreatmentController : Controller
    {
        private readonly ITreatmentData _treatmentData;

        public TreatmentController(ITreatmentData treatmentData)
        {
            _treatmentData = treatmentData;
        }
        // GET: TreatmentController
        public ActionResult Index()
        {
            var treatments = _treatmentData.GetAllTreatments();
            return View(treatments);
        }

        // GET: TreatmentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TreatmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TreatmentController/Create
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

        // GET: TreatmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TreatmentController/Edit/5
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

        // GET: TreatmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TreatmentController/Delete/5
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
