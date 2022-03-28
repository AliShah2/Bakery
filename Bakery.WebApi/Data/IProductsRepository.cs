using Bakery.WebApi.Models;
using System.Collections;
using System.Collections.Generic;

namespace Bakery.WebApi.Data
{
    public interface IProductsRepository
    {
        IList<Product> GetAll();
        Product GetById(int id);
        void Create(Product product);
        void SaveChanges();
        void Delete(Product product);
        void Update(Product product);

    }
}
