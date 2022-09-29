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
        // Add stored procs and connection string name
        private readonly ISqlDataAccess _sql;

        public ClientData(ISqlDataAccess sql)
        {
            _sql = sql;
        }
        public List<Client> GetInventory()
        {
            var output = _sql.LoadData<Client, dynamic>("stored_proc", new { }, "DBName");

            return output;
        }

        public void SaveInventoryRecord(Client client)
        {
            _sql.SaveData("", client, "");
        }
    }
}
