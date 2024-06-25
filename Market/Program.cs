using Market__CRM;


List<Users> userlist = new List<Users>();
List<Products> productlist = new List<Products>();

Users user1 = new Users();
user1.Id = 0;
user1.Name = "user1";
user1.Age = 18;
user1.PhoneNumber = "+98111";
user1.Role = "cashier";

Users user2 = new Users();
user2.Id = 1;
user2.Name = "user2";
user2.Age = 19;
user2.PhoneNumber = "+98222";
user2.Role = "senior cashier";

Category category1 = new Category();
category1.Id = 0;
category1.CategoryName = "Cay";

Category category2 = new Category();
category2.Id = 1;
category2.CategoryName = "Qend";

Products products1 = new Products();
products1.Id = 0;
products1.ProductName = "Berga";
products1.ProductPrice = 3.5;
products1.ProductCount = 10;
products1.ProductCategoryId = 0;

Products products2 = new Products
{
    Id = 1,
    ProductName = "Azerseker",
    ProductPrice = 1.5,
    ProductCount = 20,
    ProductCategoryId = 1
};





AdminManager adminManager = new AdminManager(userlist, productlist);



Usermanager cashier1 = new Usermanager(user1, productlist);


adminManager.AddUser(user1);
//adminManager.AddUser(user2);
//adminManager.Delete(user1);
adminManager.Add(products1);
adminManager.Add(products2);




//cashier1.Add(products1);
cashier1.GetAllProduct();



//adminManager.GetAllProduct();

//Console.WriteLine(adminManager._userlist[1].Name);


