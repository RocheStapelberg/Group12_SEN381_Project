using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using UkupholisaHealthcare.Library.BussinessLogic;
using UkupholisaHealthcare.Library.Models;
using UkupholisaHealthcareWebApp.Models;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class ProviderController : Controller
    {
        private readonly IProviderData _providerData;

        // Injects class for use in provider controller
        public ProviderController(IProviderData providerData)
        {
            _providerData = providerData;
        }

        // GET: ProviderController 
        public ActionResult Index()
        {
            List<Provider> providerList = _providerData.GetAllProviders();
            return View(providerList);
        }

        // GET: ProviderController/Filter/[providerName]
        public ActionResult Filter(string providerName)
        {
            List<Provider> filteredProviders = _providerData.SearchProviderByName(providerName);
            return View(filteredProviders);
        }

        public ActionResult ViewProviderTreatment(int id)
        {
            // TODO - Optimize
            Provider provider = _providerData.GetProviderById(id);
            var treatments = _providerData.GetTreatmentsByProviderId(id);
            ProviderTreatmentDisplayModel displayModel = new ProviderTreatmentDisplayModel(provider, treatments);
            return View(displayModel);
        }

        public ActionResult CreateView()
        {
            return View();
        }

        // GET: ProviderController/Create
        public ActionResult Create(Provider provider)
        {
            _providerData.InsertProvider(provider);
            return RedirectToAction("Index");
        }

        public ActionResult EditView(int id)
        {
            Provider provider = _providerData.GetProviderById(id);
            return View(provider);
        }

        public ActionResult Edit(Provider provider)
        {
            _providerData.UpdateProvider(provider);
            return RedirectToAction("Index");
        }


        // GET: ProviderController/Delete/5
        public ActionResult Delete(int id)
        {
            _providerData.DeleteProvider(id);
            return RedirectToAction("Index");
        }
    }
}
