namespace UkupholisaHealthcare.Library.DataAccess
{
    public interface ISqlDataAccess
    {
        void CommitTransaction();
        void Dispose();
        string GetConnectionString();
        List<T> LoadData<T, U>(string storedProcedure, U parameters);
        List<T> LoadDataInTransaction<T, U>(string storedProcedure, U parameters);
        void RollbackTransaction();
        void RunStoredProcedure<T>(string storedProcedure, T parameters);
        void SaveDataInTransaction<T>(string storedProcedure, T parameters);
        void StartTransaction();
    }
}