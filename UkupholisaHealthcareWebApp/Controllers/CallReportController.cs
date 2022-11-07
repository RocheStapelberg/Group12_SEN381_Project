using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using UkupholisaHealthcare.Library.BussinessLogic;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class CallReportController : Controller
    {
        private readonly ICallReportData _callReportData;
        private readonly IClientData _clientData;

        public CallReportController(ICallReportData callReportData, IClientData clientData)
        {
            _callReportData = callReportData;
            _clientData = clientData;
        }
        // GET: CallReportController
        public ActionResult Index()
        {
            var callReports = _callReportData.GetAllCallReport();
            return View(callReports);

        }

        public IActionResult CreateView(FamilyLink family)
        {
            return View(family);
        }

        public IActionResult Create(int familyId, bool isSatisfied)
        {
            CallReport report = new CallReport();
            Random rnd = new Random();

            report.Client_Id = familyId;        
            report.CallDuration = rnd.Next(30, 300);
            report.IsSatisfied = isSatisfied;

            _callReportData.InsertCallReport(report);

            return RedirectToAction("Index", "Home");   
        }

        public ActionResult ViewCallClient(int id)
        {
            Client client = _clientData.GetClientById(id);
            return View(client);
        }

        public ActionResult EmpCreateView()
        {
            return View();
        }

        // GET: ProviderController/Create
        public ActionResult EmpCreate(CallReport callReport)
        {
            _callReportData.InsertCallReport(callReport);
            return RedirectToAction("Index");
        }
    }
}
