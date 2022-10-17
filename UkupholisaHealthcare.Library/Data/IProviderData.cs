using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.Data
{
    public interface IProviderData
    {
        void DeleteProvider(int id);
        List<Provider> GetAllProviders();
        Provider GetProviderById(int id);
        void InsertProvider(Provider provider);
        List<Treatment> GetTreatmentsByProviderId(int id);
        void UpdateProvider(Provider provider);
        List<Provider> SearchProviderByName(string providerName);
    }
}