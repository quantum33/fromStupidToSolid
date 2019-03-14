using System.Collections.Generic;

namespace FromStupidToSolid.Stupid.ISP.ProductExample
{
    public interface IProduct
    {
        int Id { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        decimal Weight { get; set; }

        int Width { get; set; }

        int Height { get; set; }

        List<object> Ingredients { get; set; } // Note: object => for the demonstration, actually we would create a class "Ingredient"

        List<object> ChemicalAgents { get; set; } // same here

        bool HasSpareParts { get; set; }
    }
}