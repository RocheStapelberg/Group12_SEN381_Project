using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UkupholisaHealthcare.Library.DataAccess;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.Data
{
    public class MedicalCondition : IMedicalCondition
    {
        private readonly ISqlDataAccess _sql;

        public MedicalConditionData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<MedicalCondition> GetAllMedicalCondition()
        {
            var output = _sql.LoadData<MedicalCondition, dynamic>("spGetAllMedicalCondition", new { });
            return output;

        }
        public void InsertMedicalCondition(MedicalCondition medicalCondition)
        {
            _sql.RunStoredProcedure("spInsertMedicalCondition", medicalCondition);
        }

        public void UpdateMedicalCondition(MedicalCondition medicalCondition)
        {
            _sql.RunStoredProcedure("spUpdateMedicalCondition", medicalCondition);
        }

        public void DeleteMedicalCondition(int id)
        {
            _sql.RunStoredProcedure("spDeleteMedicalCondition", new { id });
        }

    }
}
