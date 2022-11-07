using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public interface ITreatmentData
    {
        void DeleteTreatment(int id);
        List<Treatment> GetAllTreatments();
        void InsertTreatment(Treatment treatment);
        void UpdateTreatment(Treatment treatment);
        Treatment GetTreatmentById(int id);
        List<Treatment> SearchTreatmentByName(string TreatmentName);
    }
}