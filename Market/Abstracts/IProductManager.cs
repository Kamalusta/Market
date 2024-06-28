using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Concretes;

namespace Market.Abstracts
{
    internal interface IProductManager
    {
        /* public void Add(Products products);
         public void Update(int id, string newName, double newPrice, int NewCount);
         public void Delete(Products products);*/

        public void GetAllProduct();
        public void GetProductById(int id);
        public void GetProductByCategory(Category category);
    }
}
