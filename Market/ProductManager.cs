namespace Market__CRM
{
    internal class ProductManager : IProductManager
    {
        public List<Products> ProductList;

        public virtual void Add(Products products)
        {
            bool checker = false;
            foreach (var item in ProductList)
            {
                if(item == products)
                {
                    checker = true;
                    Console.WriteLine("This product is already have");
                    break;
                }
            }
            if (checker)
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
                Console.WriteLine($"Name:{product.ProductName}\n Price:{product.ProductPrice}\n Count:{product.ProductCount}\n Category:{product.ProductCategoryId}\n");
            }
        }

        public void GetProductByCategory(Category category)
        {
            foreach (var product in ProductList)
            {
                if (category.Id == product.ProductCategoryId)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
        }

        public void GetProductById(int id)
        {
            foreach (var item in ProductList)
            {
                if (item.Id == id)
                    Console.WriteLine(item.ProductName);
            }
        }


        public void Sell(Products Product, int count)
        {
            foreach (var item in ProductList)
            {
                if (item == Product && item.ProductCount < count)
                    Console.WriteLine("There is not enought product");
                else if (item == Product)
                {
                    item.ProductCount -= count;
                }

            }
        }

        public virtual void Return(Products Product, int count)
        {
            foreach (var item in ProductList)
            {
                if (item == Product)
                    item.ProductCount += count;
            }
        }
    }
}
