using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market__CRM
{
    internal class ProductManager : IProductManager
    {
        public List<Products> ProductList;

     /*   public ProductManager(List<Products> _ProductList)
        {
            this.ProductList = _ProductList;
        }
*/
        public virtual void Add(Products products)
        {
            ProductList.Add(products);
        }

        public virtual void Delete(Products products)
        {
            ProductList.Remove(products);
        }

        public virtual void Update(int id, string newName, double newPrice, int newCount)
        {
            bool updated = false;

            foreach (var product in ProductList)
            {
                if (product.Id == id)
                {
                    product.ProductName = newName;
                    product.ProductPrice = newPrice;
                    product.ProductCount = newCount;
                    updated = true;
                    break;
                }
            }
            if (updated)

                Console.WriteLine("Product updated");
            else
                Console.WriteLine("Product not found");
        }

        public void GetAllProduct()
        {
            foreach (var product in ProductList)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        public void GetProductByCategory(Category category)
        {
            foreach(var product in ProductList)
            {
                if(category.Id == product.ProductCategoryId)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
        }

        public void GetProductById(int id)
        {
            foreach (var item in ProductList)
            {
                if(item.Id == id)
                    Console.WriteLine(item.ProductName);
            }
        }

    }
}
