using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public interface ICallReportData
    {
        List<CallReport> GetAllCallReport();

        //This method inserts a call report
        void InsertCallReport(CallReport report);

        //This method deletes a call report
        void DeleteCallReport(int id);
    }


}