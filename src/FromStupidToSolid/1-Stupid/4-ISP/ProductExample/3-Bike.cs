using System;
using System.Collections.Generic;

namespace FromStupidToSolid.Stupid.ISP.ProductExample
{
    public class Bike : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Weight { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public List<object> Ingredients
        {
            get => new List<object>(0);
            set => throw new InvalidOperationException("non-sense for a bike");
        }

        public List<object> ChemicalAgents // ???
        {
            get => new List<object>(0);
            set => throw new InvalidOperationException("non-sense for a bike");
        }

        public bool HasSpareParts { get; set; }
    }
}