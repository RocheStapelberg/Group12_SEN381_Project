using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UkupholisaHealthcare.Library.BussinessLogic;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class CallController : Controller
    {
        private readonly IClientData _clientData;

        public CallController(IClientData clientData)
        {
            _clientData = clientData;
        }
        // GET: CallController
        public ActionResult Index(string clientEmail)
        {
            var client = _clientData.GetClientByEmail(clientEmail);
            return View(client);
        }
    }
}
