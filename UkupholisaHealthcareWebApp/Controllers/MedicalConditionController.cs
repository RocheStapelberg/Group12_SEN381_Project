using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UkupholisaHealthcare.Library.BussinessLogic;

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

        // GET: MedicalConditionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }


        // GET: MedicalConditionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

    }
}
