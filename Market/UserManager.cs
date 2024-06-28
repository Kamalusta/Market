using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market__CRM
{
    internal class Usermanager : ProductManager
    {
        Users _user;
        //List<Products> _products;

        public Usermanager(Users user, List<Products> products)
        {
            _user = user;
            base.ProductList = products;
        }

        public override void Delete(Products products)
        {
            if(_user.Role != "cashier")
                base.Delete(products);
            else
                Console.WriteLine("Cashier can not delete product");
        }

        public override void Add(Products products)
        {            
            if (_user.Role != "cashier")
                base.Add(products);
            else
                Console.WriteLine("Cashier can not add product");
        }

        public override void Update(int id, string newName, double newPrice, int newCount)
        {                            
            if (_user.Role != "cashier")
                base.Update(id, newName, newPrice, newCount);
            else
                Console.WriteLine("Cashier can not add product");
        }

        public override void Return(Products Product, int count)
        {
            if (_user.Role != "cashier")
                base.Return(Product, count);
            else
                Console.WriteLine("Cashier can not return product");
        }
    }
}
