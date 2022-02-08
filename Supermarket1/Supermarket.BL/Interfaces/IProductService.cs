using Supermarket.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.BL.Interfaces
{
    public interface IProductService
    {
        Product Create(Product product);

        Product Update(Product product);

        Product Delete(int id);

        Product GetById(int id);
        IEnumerable<Product> GetAll();
    }
}
