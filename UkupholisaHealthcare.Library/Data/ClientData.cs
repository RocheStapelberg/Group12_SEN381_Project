using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UkupholisaHealthcare.Library.DataAccess;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.Data
{
    public class ClientData
    {
        //TODO - Add stored procs
        private readonly ISqlDataAccess _sql;

        public ClientData(ISqlDataAccess sql)
        {
            _sql = sql;
        }
        public List<Client> GetClients()
        {
            var output = _sql.LoadData<Client, dynamic>("", new { });

            return output;
        }

        public void SaveClient(Client client)
        {
            _sql.RunStoredProcedure("", client);
        }
    }
}
