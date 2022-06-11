using DataAccessLayer.Models;
using System.Collections.Generic;

namespace DataAccessLayer.Data
{
    public interface IBookShopRepository
    {
        public IEnumerable<User> GetUsers();

        public User GetUser(int id);

        public int AddUser(User user);

        public void UpdateUser(User user);

        public void DeleteUser(int id);
    }
}