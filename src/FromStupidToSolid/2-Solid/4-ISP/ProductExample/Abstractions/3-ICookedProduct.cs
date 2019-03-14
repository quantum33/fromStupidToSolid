using System.Collections.Generic;

namespace FromStupidToSolid.Solid.ISP.ProductExample.Abstractions
{
    public interface ICookedProduct : IWeightableProduct
    {
        List<object> Ingredients { get; set; } // Note: object => for the demonstration, actually we would create a class "Ingredient"
    }
}