using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UkupholisaHealthcare.Library.Data;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class ProviderController : Controller
    {
        private readonly IProviderData _providerData;

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
            return View();
        }

        public ActionResult CreateView()
        {
            return View();
        }

        // GET: ProviderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: ProviderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }


        // GET: ProviderController/Delete/5
        public ActionResult Delete(int id)
        {
            _providerData.DeleteProvider(id);
            return RedirectToAction("Index");
        }
    }
}
