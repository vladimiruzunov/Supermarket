using Supermarket.DL.InMemoryDb;
using Supermarket.DL.Interfaces;
using Supermarket.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.DL.InMermoryRepos
{
    public class ProductInMemoryRepository : IProductRepository
    {
        public ProductInMemoryRepository()
        {

        }
        public Product Create(Product product)
        {
            ProductInMemoryCollection.ProductDB.Add(product);
            return product;
        }

        public Product Delete(int id)
        {
            var product = ProductInMemoryCollection.ProductDB.FirstOrDefault(car => car.Id == id);
            ProductInMemoryCollection.ProductDB.Remove(product);
            return product;
        }

        public IEnumerable<Product> GetAll()
        {
            return ProductInMemoryCollection.ProductDB;
        }

        public Product GetById(int id)
        {
           return ProductInMemoryCollection.ProductDB.FirstOrDefault(car => car.Id == id);
        }

        public Product Update(Product product)
        {
            {
                var result = ProductInMemoryCollection.ProductDB.FirstOrDefault(x => x.Id == product.Id);
                result.Name = product.Name;
                result.Price = product.Price;
                return result;
            }

        }
        }
}
