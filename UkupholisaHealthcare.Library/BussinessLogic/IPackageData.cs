using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public interface IPackageData
    {
        void DeletePackage(global::System.Int32 id);
        List<Package> GetAllPackage();
        Package GetPackageId(global::System.Int32 id);
        void InsertPackage(Package package);
        void UpdatePackage(Package package);
    }
}