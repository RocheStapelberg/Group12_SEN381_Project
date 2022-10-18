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
            // TODO - Optimize----------------Roche plz check this 
            MedicalCondition medicalCondition = _medicalConditionData.GetMedicalConditionById(id);
            var treatments = _medicalConditionData.GetMedicalConditionById(id);
            MedicalConditionDisplayModel displayModel = new MedicalConditionDisplayModel(medicalCondition, treatments);
            return View(displayModel);
        }

        public ActionResult Create(MedicalCondition medicalCondition)
        {
            _providerData.InsertMedicalCondition(medicalCondition);
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
            _providerData.DeleteMedicalCondition(id);
            return RedirectToAction("Index");
        }
    }
}
