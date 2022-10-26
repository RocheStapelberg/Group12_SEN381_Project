using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public interface ITreatmentData
    {
        void DeleteTreatment(int id);
        List<Treatment> GetAllTreatments();
        void InsertTreatment(Treatment treatment);
        void UpdateTreatment(Treatment treatment);

        List<Treatment> SearchTreatmentByName(string TreatmentName);
    }
}