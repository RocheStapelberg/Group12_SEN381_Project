using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.Data
{
    public interface ITreatmentData
    {
        void DeleteTreatment(int id);
        List<Treatment> GetAllTreatments();
        void InsertTreatment(Treatment treatment);
        void UpdateTreatment(Treatment treatment);
    }
}