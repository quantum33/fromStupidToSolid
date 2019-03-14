using System.Collections.Generic;

namespace FromStupidToSolid.Solid.ISP.ProductExample.Abstractions
{
    public interface ICleaningProduct : IProduct
    {
        List<object> ChemicalAgents { get; set; } // same here
    }
}