using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace UkupholisaHealthcare.Library.DataAccess
{
    /// <summary>
    /// Main DataAccess Class
    /// </summary>
    public class SqlDataAccess : IDisposable, ISqlDataAccess
    {

        // Open connection/start transaction
        // Load using the transaction
        // Save using transaction
        // Close connection/stop transaction
        // Dispose

        private IDbConnection? _connection;
        private IDbTransaction? _transaction;
        private readonly IConfiguration? _config;
        private readonly ILogger<SqlDataAccess>? _logger;

        public SqlDataAccess(IConfiguration config, ILogger<SqlDataAccess> logger)
        {
            _config = config;
            _logger = logger;
        }

        public string GetConnectionString()
        {
            return _config.GetConnectionString("Default");
        }

        public List<T> LoadData<T, U>(string storedProcedure, U parameters)
        {
            string connectionString = GetConnectionString();

            using (IDbConnection cnn = new SqlConnection(connectionString))
            {
                List<T> rows = cnn.Query<T>(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure).ToList();

                return rows;
            }
        }

        public void RunStoredProcedure<T>(string storedProcedure, T parameters)
        {
            string connectionString = GetConnectionString();

            using (IDbConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Execute(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void StartTransaction()
        {
            string connectionString = GetConnectionString();

            _connection = new SqlConnection(connectionString);
            _connection.Open();

            _transaction = _connection.BeginTransaction();
        }
        public List<T> LoadDataInTransaction<T, U>(string storedProcedure, U parameters)
        {
            List<T> rows = _connection.Query<T>(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure, transaction: _transaction).ToList();

            return rows;
        }

        public void SaveDataInTransaction<T>(string storedProcedure, T parameters)
        {
            _connection.Execute(storedProcedure, parameters,
                commandType: CommandType.StoredProcedure, transaction: _transaction);
        }

        public void CommitTransaction()
        {
            _transaction?.Commit();
            _transaction = null;

            _connection?.Close();
            _connection = null;

        }

        public void RollbackTransaction()
        {
            _transaction?.Rollback();
            _transaction = null;

            _connection?.Close();
            _connection = null;

        }

        public void Dispose()
        {
            try
            {
                CommitTransaction();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Commit Transaction failed in dispose method.");
            }
        }

    }
}
