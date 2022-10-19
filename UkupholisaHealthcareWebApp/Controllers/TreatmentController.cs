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

        // GET: Treatment
        public ActionResult Index()
        {
            var treatments = _treatmentData.GetAllTreatments();
            return View(treatments);
        }
    }
}
