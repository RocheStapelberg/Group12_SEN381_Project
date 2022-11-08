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

        public ActionResult ViewFull(int id)
        {
            MedicalCondition med = _medicalConditionData.GetMedicalConditionById(id);
            return View(med);
        }

        public ActionResult EmpCreateView()
        {
            return View();
        }

        public ActionResult EmpCreate(MedicalCondition medicalCondition)
        {
            _medicalConditionData.InsertMedicalCondition(medicalCondition);
            return RedirectToAction("Index");
        }

        // GET: MedicalConditionController/Edit/5
        public ActionResult EditView(int id)
        {
           MedicalCondition medicalCondition= _medicalConditionData.GetMedicalConditionById(id);
            return View(medicalCondition);
        }

        public ActionResult Edit(MedicalCondition medicalCondition)
        {
            _medicalConditionData.UpdateMedicalCondition(medicalCondition);
            return RedirectToAction("Index");
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
