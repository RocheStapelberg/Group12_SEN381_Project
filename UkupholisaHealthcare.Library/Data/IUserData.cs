using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcare.Library.Data
{
    public interface IUserData
    {
        void DeleteUser(int id);
        List<User> GetAllUsers();
        List<User> GetUserByEmail(string email);
        List<User> GetUserById(int id);
        void InsertUser(User user);
        void UpdateUser(User user);
    }
}