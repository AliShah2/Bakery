using Bakery.WebApi.Models;
using System.Collections.Generic;

namespace Bakery.WebApi.Data
{
    public class MockProductsRepository : IProductsRepository
    {
        public void Create(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new System.NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            return new List<Product>
            { 
                new Product{Id=1, Title = "Test bread 1", Category = "Breads", Price=100.0 },
                new Product{Id=2, Title = "Test bread 2", Category = "Breads", Price=50.0 }
            };
        }

        public Product GetById(int id)
        {
            return new Product { Id = 1, Title = "Test bread 1", Category = "Breads", Price = 100.0 };
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
