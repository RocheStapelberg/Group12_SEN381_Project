using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void InsertFamily(FamilyLink familyLink)
        {
            _sql.RunStoredProcedure("", familyLink);
        }

        public void UpdateFamily(FamilyLink familyLink)
        {
            _sql.RunStoredProcedure("", familyLink);
        }

        public void DeleteFamily(int id)
        {
            _sql.RunStoredProcedure("", id);
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

        public List<Client> GetClients()
        {
            var output = _sql.LoadData<Client, dynamic>("spGetAllClient", new { });
            return output;
        }

        public void SaveClient(Client client)
        {
            _sql.RunStoredProcedure("", client);
        }

        public void DeleteClient(int id)
        {
            _sql.RunStoredProcedure("", id);
        }

        public void UpdateClient(Client client)
        {
            _sql.RunStoredProcedure("", client);
        }
    }
}
