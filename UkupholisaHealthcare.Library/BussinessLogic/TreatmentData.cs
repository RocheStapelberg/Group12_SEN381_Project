using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UkupholisaHealthcare.Library.DataAccess;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public class TreatmentData : ITreatmentData
    {
        private readonly ISqlDataAccess _sql;

        public TreatmentData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<Treatment> GetAllTreatments()
        {
            var output = _sql.LoadData<Treatment, dynamic>("spGetAllTreatment", new { });
            return output;
        }
        public Treatment GetTreatmentById(int id)
        {
            var output = _sql.LoadData<Treatment, dynamic>("spGetTreatmentById", new { id });
            return output[0];
        }
        public void InsertTreatment(Treatment treatment)
        {
            _sql.RunStoredProcedure("spInsertTreatment", treatment);
        }

        public void UpdateTreatment(Treatment treatment)
        {
            _sql.RunStoredProcedure("spUpdateTreatment", treatment);
        }

        public void DeleteTreatment(int id)
        {
            _sql.RunStoredProcedure("spDeleteTreatment", new { id });
        }

        public List<Treatment> SearchTreatmentByName(string TreatmentName)
        {
            var output = _sql.LoadData<Treatment, dynamic>("spSearchTreatmentByName", new { TreatmentName });
            return output;
        }
        public Treatment GetTreatmentById(int id)
        {
            var output = _sql.LoadData<Treatment, dynamic>("spGetTreatmentById", new { id });
            return output[0];
        }

    }
}
