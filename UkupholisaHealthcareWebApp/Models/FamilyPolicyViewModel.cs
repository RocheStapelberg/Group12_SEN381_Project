using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcareWebApp.Models
{
    public class FamilyPolicyViewModel
    {
        public FamilyLink family { get; set; }
        public List<Policy> policies { get; set; }
    }
}
