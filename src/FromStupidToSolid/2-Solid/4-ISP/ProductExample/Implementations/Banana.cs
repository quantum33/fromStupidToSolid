using System.Collections.Generic;
using FromStupidToSolid.Solid.ISP.ProductExample.Abstractions;

namespace FromStupidToSolid.Solid.ISP.ProductExample.Implementations
{
    public class Banana : IProduct
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}