using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UkupholisaHealthcare.Library.BussinessLogic;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientData _clientData;

        public ClientController(IClientData clientData)
        {
            _clientData = clientData;
        }

        // GET: ClientController
        public ActionResult Index()
        {
            List<FamilyLink> families = _clientData.GetFamilies();
            return View(families);
        }
        public ActionResult Filter(string FirstName)
        {
            List<Client> filteredClients = _clientData.SearchClientByName(FirstName);
            return View(filteredClients);
        }



        public ActionResult ViewMembers(int id)
        {
            List<Client> members = _clientData.GetClientsByFamilyId(id);
            return View(members);
        }
    }
}
