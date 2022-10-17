namespace UkupholisaHealthcare.Library.Data
{
    public interface IMedicalCondition
    {
        void DeleteMedicalCondition(global::System.Int32 id);
        List<MedicalCondition> GetAllMedicalCondition();
        void InsertMedicalCondition(MedicalCondition medicalCondition);
        void UpdateMedicalCondition(MedicalCondition medicalCondition);
    }
}