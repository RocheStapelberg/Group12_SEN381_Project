using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UkupholisaHealthcare.Library.BussinessLogic;

using UkupholisaHealthcare.Library.Models;
using UkupholisaHealthcareWebApp.Models;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class MedicalConditionController : Controller
    {
        private readonly IMedicalConditionData _medicalConditionData;

        public MedicalConditionController(IMedicalConditionData medicalConditionData)
        {
            _medicalConditionData = medicalConditionData;
        }

        // GET: MedicalConditionController
        public ActionResult Index()
        {
            List<MedicalCondition> MedicalConditionList = _medicalConditionData.GetAllMedicalCondition();
            return View(MedicalConditionList);
        }
        // GET: MedicalConditionController/Details/5
        public ActionResult ViewMedicalConditions(int id)
        {
            return View();
        }

        public ActionResult CreateView()
        {
            return View();
        }

        // GET: ProviderController/Create
        public ActionResult Create(MedicalCondition medicalCondition)
        {
            _medicalConditionData.InsertMedicalCondition(medicalCondition);
            return RedirectToAction("Index");
        }

        // GET: MedicalConditionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: MedicalConditionController/Delete/5
        public ActionResult Delete(int id)
        {
            _medicalConditionData.DeleteMedicalCondition(id);
            return RedirectToAction("Index");
        }

        public ActionResult Filter(string ConditionName)
        {
            List<MedicalCondition> filteredMedicalConditions = _medicalConditionData.SearchMedicalConditionByName(ConditionName);
            return View(filteredMedicalConditions);
        }
    }
}
