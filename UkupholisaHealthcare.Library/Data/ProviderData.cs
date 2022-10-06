using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UkupholisaHealthcare.Library.DataAccess;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.Data
{
    public class ProviderData
    {
        private readonly ISqlDataAccess _sql;

        public ProviderData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<Provider> GetProvider()
        {
            var output = _sql.LoadData<Provider, dynamic>("", new { }, "Default");

            return output;
        }

        public void SaveProvider(Provider provider)
        {
            _sql.SaveData("", provider, "Default");
        }
    }
}
