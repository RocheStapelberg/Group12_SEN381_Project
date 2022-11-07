using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public interface ICallReportData
    {
        List<CallReport> GetAllCallReport();
        void InsertCallReport(CallReport report);

        void DeleteCallReport(int id);
    }


}