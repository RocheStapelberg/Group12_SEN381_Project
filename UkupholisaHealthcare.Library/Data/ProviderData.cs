using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UkupholisaHealthcare.Library.DataAccess;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.Data
{
    /// <summary>
    /// Provider data class
    /// </summary>
    public class ProviderData : IProviderData
    {
        private readonly ISqlDataAccess _sql;

        public ProviderData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<Provider> GetAllProviders()
        {
            var output = _sql.LoadData<Provider, dynamic>("spGetAllProviders", new { });

            return output;
        }

        public void InsertProvider(Provider provider)
        {
            _sql.RunStoredProcedure("spInsertProvider", provider);
        }

        public void UpdateProvider(Provider provider)
        {
            _sql.RunStoredProcedure("spUpdateProvider", provider);
        }

        public void DeleteProvider(int id)
        {
            _sql.RunStoredProcedure("spDeleteProvider", new { id });
        }
    }
}
