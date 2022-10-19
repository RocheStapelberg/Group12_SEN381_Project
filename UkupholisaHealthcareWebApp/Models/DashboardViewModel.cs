using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcareWebApp.Models
{
    public class DashboardViewModel
    {
        public List<Client>? clientList { get; set; }
        public List<Provider>? providerList { get; set; }
    }
}
