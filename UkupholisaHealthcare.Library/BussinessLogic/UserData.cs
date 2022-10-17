using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UkupholisaHealthcare.Library.DataAccess;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.BussinessLogic
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _sql;

        public UserData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<User> GetAllUsers()
        {
            var output = _sql.LoadData<User, dynamic>("spGetAllUsers", new { });
            return output;
        }

        public List<User> GetUserById(int id)
        {
            var output = _sql.LoadData<User, dynamic>("spGetUserById", new { id });
            return output;
        }

        public List<User> GetUserByEmail(string email)
        {
            var output = _sql.LoadData<User, dynamic>("spGetUserByEmail", new { email });
            return output;
        }

        public void InsertUser(User user)
        {
            _sql.RunStoredProcedure("spInsertUser", user);
        }

        public void DeleteUser(int id)
        {
            _sql.RunStoredProcedure("spDeleteUser", new { id });
        }

        public void UpdateUser(User user)
        {
            _sql.RunStoredProcedure("spUpdateUser", user);
        }
    }
}
