using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UkupholisaHealthcare.Library.BussinessLogic;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class TreatmentController : Controller
    {
        private readonly ITreatmentData _treatmentData;

        public TreatmentController(ITreatmentData treatmentData)
        {
            _treatmentData = treatmentData;
        }

        // GET: Treatment
        public ActionResult Index()
        {
            var treatments = _treatmentData.GetAllTreatments();
            return View(treatments);
        }

        public ActionResult Filter(string TreatmentName)
        {
            List<Treatment> filteredTreatment = _treatmentData.SearchTreatmentByName(TreatmentName);
            return View(filteredTreatment);
        }
        public ActionResult CreateView()
        {
            return View();
        }
        public ActionResult EditView(int id)
        {
            Treatment treatment= _treatmentData.GetTreatmentById(id);
            return View(treatment);
        }

        public ActionResult Edit(Treatment treatment)
        {
            _treatmentData.UpdateTreatment(treatment);
            return RedirectToAction("Index");
        }
        // GET: ProviderController/Create
        public ActionResult Create(Treatment treatment)
        {
            _treatmentData.InsertTreatment(treatment);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            _treatmentData.DeleteTreatment(id);
            return RedirectToAction("Index");
        }

    }
}
