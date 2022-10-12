using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.Data
{
    public interface IProviderData
    {
        void DeleteProvider(int Id);
        List<Provider> GetAllProviders();
        void SaveProvider(Provider provider);
    }
}