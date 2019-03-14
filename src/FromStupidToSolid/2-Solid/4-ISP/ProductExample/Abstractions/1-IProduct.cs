using System.Collections.Generic;

namespace FromStupidToSolid.Solid.ISP.ProductExample.Abstractions
{
    public interface IProduct
    {
        int Id { get; set; }

        string Name { get; set; }

        string Description { get; set; }
    }
}