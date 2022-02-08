using Supermarket.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.DL.InMemoryDb
{
    public class ProductInMemoryCollection
    {
        public static List<Product> ProductDB = new List<Product>()
        {
            new Product()
            {
                Name = "Banan",
                Id = 1,
                Price = 2.50
            },
            new Product()
            {
                Id = 2,
                Name = "Portokal",
                Price = 2.10
            },
            new Product()
            {
                Id=3,
                Name = "Limon",
                Price= 3.30
            }
        };
    }
}
