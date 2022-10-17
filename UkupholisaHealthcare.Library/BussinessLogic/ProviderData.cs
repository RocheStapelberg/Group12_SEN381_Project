using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UkupholisaHealthcare.Library.DataAccess;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
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

        // Run the spGetAllProviders stored procedure to retrieve data from the database.
        public List<Provider> GetAllProviders()
        {
            var output = _sql.LoadData<Provider, dynamic>("spGetAllProviders", new { });
            return output;
        }

        public Provider GetProviderById(int id)
        {
            var output = _sql.LoadData<Provider, dynamic>("spGetProviderById", new { id });
            return output[0];
        }

        public List<Treatment> GetTreatmentsByProviderId(int ProviderId)
        {
            var output = _sql.LoadData<Treatment, dynamic>("spGetTreatmentsByProviderId", new { ProviderId });
            return output;
        }

        public List<Provider> SearchProviderByName(string providerName)
        {
            var output = _sql.LoadData<Provider, dynamic>("spSearchProviderByName", new { providerName });
            return output;
        }

        // Run the spInsertProvider stored procedure to insert data into the database.
        public void InsertProvider(Provider provider)
        {
            _sql.RunStoredProcedure("spInsertProvider", provider);
        }

        // Run the spUpdateProvider stored procedure to update data in the database.
        public void UpdateProvider(Provider provider)
        {
            _sql.RunStoredProcedure("spUpdateProvider", provider);
        }
        // Run the spDeleteProvider stored procedure to delete data in the database.
        public void DeleteProvider(int id)
        {
            _sql.RunStoredProcedure("spDeleteProvider", new { id });
        }
    }
}
