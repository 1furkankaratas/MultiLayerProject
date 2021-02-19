using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private readonly List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product {ProductId = 1,CategoryId = 1,ProductName = "Glass",UnitPrice = 15,UnitsInStock = 15},
                new Product {ProductId = 2,CategoryId = 1,ProductName = "Groin",UnitPrice = 500,UnitsInStock = 3},
                new Product {ProductId = 3,CategoryId = 2,ProductName = "Computer",UnitPrice = 1500,UnitsInStock = 2},
                new Product {ProductId = 4,CategoryId = 2,ProductName = "Keyboard",UnitPrice = 150,UnitsInStock = 65},
                new Product {ProductId = 5,CategoryId = 3,ProductName = "Cell Phone",UnitPrice = 85,UnitsInStock = 1}

            };
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            Product p = _products.FirstOrDefault(x => x.ProductId == product.ProductId);

            p.ProductName = product.ProductName;
            p.UnitsInStock = product.UnitsInStock;
            p.UnitPrice = product.UnitPrice;
            p.CategoryId = product.CategoryId;

        }

        public void Delete(Product product)
        {
            Product p = _products.FirstOrDefault(x => x.ProductId == product.ProductId);

            _products.Remove(p);
        }

        public List<Product> GetAllGategory(int categoryId)
        {
            List<Product> p = _products.Where(x => x.CategoryId == categoryId).ToList();

            return p;

        }
    }
}
