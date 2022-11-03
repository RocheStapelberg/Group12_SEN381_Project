using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UkupholisaHealthcare.Library.DataAccess;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public class PolicyData : IPolicyData
    {
        private readonly ISqlDataAccess _sql;

        public PolicyData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<Policy> GetPolicies()
        {
            var output = _sql.LoadData<Policy, dynamic>("spGetAllPolicy", new { });
            return output;
        }

        public void AddPolicyToFamily(int FamilyLink_Id, int Policy_Id)
        {
            _sql.RunStoredProcedure("spInsertFamilyLinkPolicy", new { FamilyLink_Id, Policy_Id });
        }

        public void InsertPolicy(Policy policy)
        {
            _sql.RunStoredProcedure("spInsertPolicy", policy);
        }

        public void DeletePolicy(int id)
        {
            _sql.RunStoredProcedure("spDeletePolicy", new {id});
        }
    }
}
