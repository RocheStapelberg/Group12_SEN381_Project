using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public interface IPolicyData
    {
        List<Policy> GetPolicies();
        void AddPolicyToFamily(int FamilyLink_Id, int Policy_Id);
        Policy GetPolicyById(int id);
        void InsertPolicy(Policy policy);

        void DeletePolicy(int id);
        
        void UpdatePolicy(Policy policy);
        List<int> GetPolicyCount();
        List<Policy> GetPoliciesByFamilyId(int family_Id);
    }

}