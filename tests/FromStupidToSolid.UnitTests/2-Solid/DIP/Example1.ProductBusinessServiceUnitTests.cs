using FromStupidToSolid.Solid.DIP.Example1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FromStupidToSolid.UnitTests.Solid.DIP
{
    public class FakeDal : IProductDal
    {
        private readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "my product #1" },
            new Product { Id = 2, Name = "my product #2" },
            new Product { Id = 3, Name = "my product #3" },
            new Product { Id = 4, Name = "my product #4" },
            new Product { Id = 5, Name = "my product #5" },
            new Product { Id = 6, Name = "my product #6" },
        };

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }
    }

    [TestClass]
    public class ProductBusinessServiceUnitTests
    {
        [TestMethod]
        public void GetProductsWithEvenId_Succeed()
        {
            var dal = new FakeDal();
            var productBusinessService = new ProductBusinessService(dal);

            IEnumerable<Product> products = productBusinessService.GetProductsWithEvenId();

            foreach (Product product in products)
            {
                Assert.IsTrue(product.Id % 2 == 0);
            }
        }
    }
}
