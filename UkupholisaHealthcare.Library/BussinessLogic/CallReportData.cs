using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UkupholisaHealthcare.Library.DataAccess;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public class CallReportData : ICallReportData
    {
        private readonly ISqlDataAccess _sql;

        public CallReportData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<CallReport> GetAllCallReport()
        {
            var ouput = _sql.LoadData<CallReport, dynamic>("spGetAllCallReport", new { });
            return ouput;
        }

        public void InsertCallReport(CallReport report)
        {
            _sql.RunStoredProcedure("spInsertCallReport", report);
        }

        public void DeleteCallReport(int id)
        {
            _sql.RunStoredProcedure("spDeleteCallReport", new { id });
        }

    }
}
