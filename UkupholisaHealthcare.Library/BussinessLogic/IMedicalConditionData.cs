using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public interface IMedicalConditionData
    {
        void DeleteMedicalCondition(int id);
        List<MedicalCondition> GetAllMedicalCondition();
        void InsertMedicalCondition(MedicalCondition medicalCondition);
        void UpdateMedicalCondition(MedicalCondition medicalCondition);
        MedicalCondition GetMedicalConditionById(int id);
        List<MedicalCondition> SearchMedicalConditionByName(string ConditionName);
    }
}