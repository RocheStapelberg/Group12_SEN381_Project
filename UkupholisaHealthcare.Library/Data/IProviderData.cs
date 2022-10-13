using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.Data
{
    public interface IProviderData
    {
        void DeleteProvider(int id);
        List<Provider> GetAllProviders();
        void InsertProvider(Provider provider);
        void UpdateProvider(Provider provider);
    }
}