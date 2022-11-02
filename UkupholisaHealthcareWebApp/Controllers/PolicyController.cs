using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UkupholisaHealthcare.Library.BussinessLogic;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class PolicyController : Controller
    {
        private readonly IPolicyData _policyData;

        public PolicyController(IPolicyData policyData)
        {
            _policyData = policyData;
        }
        // GET: PolicyController
        public ActionResult Index()
        {
            List<Policy> policies = _policyData.GetPolicies();
            return View(policies);
        }


        public ActionResult CreateView()
        {
            return View();
        }

        // GET: PolicyController/Create
        public ActionResult Create(Policy policy)
        {
            _policyData.InsertPolicy(policy);
            return RedirectToAction("Index");
        }
    }
}
