using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UkupholisaHealthcare.Library.DataAccess;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.Data
{
    public class MedicalConditionData : IMedicalCondition
    {
        private readonly ISqlDataAccess _sql;

        public MedicalConditionData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<MedicalConditionData> GetAllMedicalCondition()
        {
            var output = _sql.LoadData<MedicalConditionData, dynamic>("spGetAllMedicalCondition", new { });
            return output;

        }
        public void InsertMedicalCondition(MedicalConditionData medicalConditionData)
        {
            _sql.RunStoredProcedure("spInsertMedicalCondition", medicalConditionData);
        }

        public void UpdateMedicalCondition(MedicalConditionData medicalConditionData)
        {
            _sql.RunStoredProcedure("spUpdateMedicalCondition", medicalConditionData);
        }

        public void DeleteMedicalCondition(int id)
        {
            _sql.RunStoredProcedure("spDeleteMedicalCondition", new { id });
        }

    }
}
