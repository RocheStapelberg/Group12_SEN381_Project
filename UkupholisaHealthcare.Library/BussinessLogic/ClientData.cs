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

        //This method finds the families and displays them
        public List<FamilyLink> GetFamilies()
        {
            var output = _sql.LoadData<FamilyLink, dynamic>("spGetAllFamilies", new { });
            return output;
        }
        //This method finds the families by the family name and displays them
        public FamilyLink GetFamilyByFamilyName(string familyName)
        {
            var output = _sql.LoadData<FamilyLink, dynamic>("spGetFamilyByFamilyName", new { familyName });
            return output[0];
            
        }
        //This method finds the family by their family ID
        public FamilyLink GetFamilyByFamilyId(int id)
        {
            var output = _sql.LoadData<FamilyLink, dynamic>("spGetFamilyById", new { id });
            return output[0];

        }

        //This method allows for the insertion of a family
        public void InsertFamily(FamilyLink familyLink)
        {
            _sql.RunStoredProcedure("spInsertFamily", familyLink);
        }

        //This method allows to update family information
        public void UpdateFamily(FamilyLink familyLink)
        {
            _sql.RunStoredProcedure("", familyLink);
        }

        //This method allows for the deletion of a family unit
        public void DeleteFamily(int id)
        {
            _sql.RunStoredProcedure("spDeleteFamily", new {id});
        }

        //This method finds the client by their family id number
        public List<Client> GetClientsByFamilyId(int id)
        {
            var output = _sql.LoadData<Client, dynamic>("spGetClientsByFamilyId", new { id });
            return output;
        }

        //This method finds the client by their email address 
        public Client GetClientByEmail(string email)
        {
            var output = _sql.LoadData<Client, dynamic>("spGetClientByEmail", new { email });
            return output[0];
        }

        //This method finds the client by their id
        public Client GetClientById(int id)
        {
            var output = _sql.LoadData<Client, dynamic>("spGetClientById", new { id });
            return output[0];
        }

        //This method finds all clients and displays them
        public List<Client> GetClients()
        {
            var output = _sql.LoadData<Client, dynamic>("spGetAllClient", new { });
            return output;
        }

        //This method allows for the insertion of a client to the database
        public void SaveClient(Client client)
        {
            _sql.RunStoredProcedure("spInsertClient", client);
        }

        //This method allows for the deletion of a client 
        public void DeleteClient(int id)
        {
            _sql.RunStoredProcedure("spDeleteClient", new {id});
        }

        //This method allows to update client information
        public void UpdateClient(Client client)
        {
            _sql.RunStoredProcedure("", client);
        }

        //This method allows for the search of a client
        public List<Client> SearchClientByName(string FirstName)
        {
            var output = _sql.LoadData<Client, dynamic>("spSearchClientByName", new { FirstName });
            return output;
        }

    }
}
