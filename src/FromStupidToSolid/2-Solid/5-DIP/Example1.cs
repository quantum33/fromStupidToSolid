using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FromStupidToSolid.Solid.DIP.Example1
{
    public interface IProductDal
    {
        IEnumerable<Product> GetProducts();
    }

    public class SqlServerProductDal : IProductDal
    {
        public IEnumerable<Product> GetProducts()
        {
            // read from SQL server database
            throw new NotImplementedException();
        }

        // ...
    }

    public class PostgresSqlProductDal : IProductDal
    {
        public IEnumerable<Product> GetProducts()
        {
            // read from Postgres SQL database
            throw new NotImplementedException();
        }

        // ...
    }

    public class ProductBusinessService
    {
        private readonly IProductDal _dal;

        public ProductBusinessService(IProductDal dal)
        {
            _dal = dal ?? throw new ArgumentNullException(nameof(dal));
        }

        public IEnumerable<Product> GetProductsWithEvenId()
        {
            // Consider we have a (weird) business rule: "even id product"
            return _dal.GetProducts().Where(p => p.Id % 2 == 0);
        }
    }

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
