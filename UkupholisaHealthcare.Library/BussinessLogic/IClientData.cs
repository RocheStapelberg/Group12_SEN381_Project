using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public interface IClientData
    {
        void DeleteClient(int id);
        void DeleteFamily(int id);
        List<Client> GetClients();
        List<Client> GetClientsByFamilyId(int id);
        List<FamilyLink> GetFamilies();
        Client GetClientByEmail(string email);
        void InsertFamily(FamilyLink familyLink);
        void SaveClient(Client client);
        void UpdateClient(Client client);
        void UpdateFamily(FamilyLink familyLink);
    }
}