using Bakery.WebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.WebApi.Data
{
    public class SqlProductsRepo : IProductsRepository
    {
        private readonly BakeryContext _dbContext;

        public SqlProductsRepo(BakeryContext context)
        {
            this._dbContext = context;
        }

        public void Create(Product product)
        {
            _dbContext.Products.Add(product);
        }

        public void Delete(Product product)
        {
            _dbContext.Products.Remove(product);
        }

        public IList<Product> GetAll()
        {
            return _dbContext.Products.ToList<Product>();
        }

        public Product GetById(int id)
        {
            return _dbContext.Products.Where(p => p.Id == id).FirstOrDefault();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Update(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
