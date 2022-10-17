using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcareWebApp.Models
{
    public class ProviderTreatmentDisplayModel
    {
        public ProviderTreatmentDisplayModel(Provider provider, List<Treatment> treatments)
        {
            this.provider = provider;
            this.treatments = treatments;
        }

        public Provider provider { get; set; }
        public List<Treatment> treatments { get; set; }


    }
}
