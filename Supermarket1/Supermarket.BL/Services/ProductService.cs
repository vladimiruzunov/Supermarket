using Supermarket.BL.Interfaces;
using Supermarket.Models.DTO;
using Supermarket.DL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.BL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productrepository;
        public ProductService(IProductRepository productRepository)
        {
            _productrepository = productRepository;
        }
        public Product Create(Product product)
        {
            var index = _productrepository.GetAll().OrderByDescending(x => x.Id).FirstOrDefault()?.Id;

            product.Id = (int)(index != null ? index + 1 : 1);

            return _productrepository.Create(product);
        }

        public Product Delete(int id)
        {
            return _productrepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
           return _productrepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productrepository.GetById(id);
        }

        public Product Update(Product car)
        {
            return _productrepository.Update(car);
        }
    }
}
