using System;
using System.Collections.Generic;
using System.Dynamic;
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
        public Policy GetPolicyById(int id)
        {
            var output = _sql.LoadData<Policy, dynamic>("spGetPolicyById", new { id });
            return output[0];
        }
        public void UpdatePolicy(Policy policy)
        {
            _sql.RunStoredProcedure("spUpdatePolicy", policy);
        }

        public List<int> GetPolicyCount()
        {
            var output = _sql.LoadData<int, dynamic>("spCountPolicies", new { });
            return output;
        }
        public List<Policy> GetPolicies()
        {
            var output = _sql.LoadData<Policy, dynamic>("spGetAllPolicy", new { });
            return output;
        }

        public List<Policy> GetPoliciesByFamilyId(int family_Id)
        {
            var output = _sql.LoadData<Policy, dynamic>("spGetPoliciesByFamilyId", new { family_Id });
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
