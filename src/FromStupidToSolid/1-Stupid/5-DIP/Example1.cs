using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FromStupidToSolid.Stupid.DIP.Example1
{
    public class ProductBusinessService
    {
        private readonly ProductDal _dal = new ProductDal();

        public IEnumerable<Product> GetProductsWithEvenId()
        {
            // Consider we have a (weird) business rule: "even id product"
            return _dal.GetProducts().Where(p => p.Id % 2 == 0);
        }
    }

    public class ProductDal
    {
        public IEnumerable<Product> GetProducts()
        {
            // eg: read from SQL database
            // ...
            return new List<Product>();
        }

        // ...
    }

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
