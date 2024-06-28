using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Concretes
{
    internal class AdminManager : ProductManager
    {

        public List<Users> _userlist;

        public AdminManager(List<Users> users, List<Products> products)
        {
            _userlist = users;
            ProductList = products;
        }

        public void AddUser(Users user)
        {
            _userlist.Add(user);
        }

        public void DeleteUser(Users user)
        {
            _userlist.Remove(user);
        }
    }
}
