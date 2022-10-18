using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UkupholisaHealthcare.Library.DataAccess;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public class PackageData
    {
        private readonly ISqlDataAccess _sql;

        public PackageData(ISqlDataAccess sql)
        {
            _sql = sql;
        }
        public List<Package> GetAllPackage()
        {
            var output = _sql.LoadData<Package, dynamic>("spGetAllPackage", new { });
            return output;

        }
        public Package GetPackageId(int id)
        {
            var output = _sql.LoadData<Package, dynamic>("spGetPackageById", new { id });
            return output[0];
        }
        public void InsertPackage(Package package)
        {
            _sql.RunStoredProcedure("spInsertPackage", package);
        }

        public void UpdatePackage(MedicalCondition package)
        {
            _sql.RunStoredProcedure("spUpdatePackage", package);
        }

        public void DeletePackage(int id)
        {
            _sql.RunStoredProcedure("spDeletePackage", new { id });
        }
    }
}
