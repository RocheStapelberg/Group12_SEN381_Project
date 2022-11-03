﻿using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public interface IPolicyData
    {
        List<Policy> GetPolicies();
        void AddPolicyToFamily(int FamilyLink_Id, int Policy_Id);
        Policy GetPolicyById(int id);
        void InsertPolicy(Policy policy);
        void UpdatePolicy(Policy policy);
    }

}