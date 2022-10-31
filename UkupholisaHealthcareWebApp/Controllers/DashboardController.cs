using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UkupholisaHealthcare.Library.BussinessLogic;
using UkupholisaHealthcare.Library.Models;
using UkupholisaHealthcareWebApp.Models;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IClientData _clientData;
        private readonly IProviderData _providerData;

        public DashboardController(IClientData clientData, IProviderData providerData)
        {
            _clientData = clientData;
            _providerData = providerData;
        }

        // GET: DashboardController
        public ActionResult Index()
        {
            List<Client> clients = _clientData.GetClients();
            List<Provider> providers = _providerData.GetAllProviders();
            DashboardViewModel model = new DashboardViewModel();

            model.clientList = clients;
            model.providerList = providers;

            string[] memberTypes = {"AccountHolder", "Adult", "Child"};

            var count = clients.GroupBy(x => x.MemberType).Select(z => z.Count());

            ViewBag.MEMBERTYPES = memberTypes;
            ViewBag.COUNT = count;
            return View(model);
        }

    }
}
