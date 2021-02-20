using Business.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var product in productManager.GetProductDetails())
            {
                
                    Console.WriteLine("  -- "+ product.ProductName + ", " + product.CategoryName);
            }

        }
    }
}
