using Business.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            Product product1 = new Product
            {
                ProductName = "Deneme",
                CategoryId = 1,
                UnitPrice = 10,
                UnitsInStock = 10
            };

            var result = productManager.Add(product1);

            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            

            

            Console.WriteLine("-----------");

            foreach (var product in productManager.GetProductDetails().Data)
            {
                
                    Console.WriteLine("  -- "+ product.ProductName + ", " + product.CategoryName);
            }

        }
    }
}
