using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public interface IPolicyData
    {
        List<Policy> GetPolicies();
        void AddPolicyToFamily(int FamilyLink_Id, int Policy_Id);
    }
}