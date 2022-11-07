using UkupholisaHealthcare.Library.DataAccess;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public class ClientData : IClientData
    {
        //TODO - Add stored procs
        private readonly ISqlDataAccess _sql;

        public ClientData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<FamilyLink> GetFamilies()
        {
            var output = _sql.LoadData<FamilyLink, dynamic>("spGetAllFamilies", new { });
            return output;
        }

        public FamilyLink GetFamilyByFamilyName(string familyName)
        {
            var output = _sql.LoadData<FamilyLink, dynamic>("spGetFamilyByFamilyName", new { familyName });
            return output[0];
            
        }

        public FamilyLink GetFamilyByFamilyId(int id)
        {
            var output = _sql.LoadData<FamilyLink, dynamic>("spGetFamilyById", new { id });
            return output[0];

        }
        public void InsertFamily(FamilyLink familyLink)
        {
            _sql.RunStoredProcedure("spInsertFamily", familyLink);
        }

        public void UpdateFamily(FamilyLink familyLink)
        {
            _sql.RunStoredProcedure("", familyLink);
        }

        public void DeleteFamily(int id)
        {
            _sql.RunStoredProcedure("spDeleteFamily", new {id});
        }
   
        public List<Client> GetClientsByFamilyId(int id)
        {
            var output = _sql.LoadData<Client, dynamic>("spGetClientsByFamilyId", new { id });
            return output;
        }

        public Client GetClientByEmail(string email)
        {
            var output = _sql.LoadData<Client, dynamic>("spGetClientByEmail", new { email });
            return output[0];
        }

        public Client GetClientById(int id)
        {
            var output = _sql.LoadData<Client, dynamic>("spGetClientById", new { id });
            return output[0];
        }

        public List<Client> GetClients()
        {
            var output = _sql.LoadData<Client, dynamic>("spGetAllClient", new { });
            return output;
        }

        public void SaveClient(Client client)
        {
            _sql.RunStoredProcedure("spInsertClient", client);
        }

        public void DeleteClient(int id)
        {
            _sql.RunStoredProcedure("spDeleteClient", new {id});
        }

        public void UpdateClient(Client client)
        {
            _sql.RunStoredProcedure("", client);
        }

        public List<Client> SearchClientByName(string FirstName)
        {
            var output = _sql.LoadData<Client, dynamic>("spSearchClientByName", new { FirstName });
            return output;
        }

    }
}
