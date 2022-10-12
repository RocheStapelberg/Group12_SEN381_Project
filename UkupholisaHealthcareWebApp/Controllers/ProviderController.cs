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

        // GET: ProviderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProviderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProviderController/Create
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

        // GET: ProviderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProviderController/Edit/5
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

        // GET: ProviderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProviderController/Delete/5
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
