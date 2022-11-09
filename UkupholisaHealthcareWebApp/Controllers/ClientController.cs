using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UkupholisaHealthcare.Library.BussinessLogic;
using UkupholisaHealthcare.Library.Models;
using UkupholisaHealthcareWebApp.Models;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientData _clientData;
        private readonly IPolicyData _policyData;
        private readonly ICallReportData _callReportData;

        public ClientController(IClientData clientData, IPolicyData policyData, ICallReportData callReportData)
        {
            _clientData = clientData;
            _policyData = policyData;
            _callReportData = callReportData;
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

        public ActionResult ViewFamilyPolicy(int id)
        {
            List<Policy> policies = _policyData.GetPoliciesByFamilyId(id);
            return View(policies);
        }
        public ActionResult ClientInfo()
        {
            return View();
        }
        public ActionResult CreateView()
        {
            return View();
        }
        public ActionResult CreateClient(Client client)
        {
            // Create family
            FamilyLink family = new FamilyLink();
            // Set family name to client Surname
            family.FamilyName = client.Surname;
            //Insert family into database
            _clientData.InsertFamily(family);
            //Get family again
            family = _clientData.GetFamilyByFamilyName(family.FamilyName);
            // Set client familyLink id to family id
            client.FamilyLink_Id = family.Id;
            // Insert client
            _clientData.SaveClient(client);

            return RedirectToAction("AddFamilyPolicy", family);
        }

        public ActionResult AddFamilyPolicy(FamilyLink family)
        {
            FamilyPolicyViewModel familyPolicy = new FamilyPolicyViewModel();
            familyPolicy.family = family;
            familyPolicy.policies = _policyData.GetPolicies();
            ViewBag.CurrentId = family.Id;
            return View(familyPolicy);
        }

        public ActionResult AddChosenPolicyToFamily(int familyId, int policyId)
        {
            _policyData.AddPolicyToFamily(familyId, policyId);
            var family = _clientData.GetFamilyByFamilyId(familyId);
            return RedirectToAction("CreateView", "CallReport", family);
        }

        public ActionResult EditView(int id)
        {
            Client client = _clientData.GetClientById(id);
            return View(client);
        }

        public ActionResult Edit(Client client)
        {
            _clientData.UpdateClient(client);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            _clientData.DeleteClient(id);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteFamily(int id)
        {
            _clientData.DeleteFamily(id);
            return RedirectToAction("Index");
        }
    }
}
