using System;
using System.Collections.Generic;

namespace FromStupidToSolid.Stupid.ISP.ProductExample
{
    public class Banana : IProduct
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Weight { get; set; }

        public int Width // ???
        {
            get => 0; // what to do?
            set => throw new InvalidOperationException("non-sense for a banana");
        }

        public int Height // ???
        {
            get => 0; // what to do?
            set => throw new InvalidOperationException("non-sense for a banana");
        }

        public List<object> Ingredients  // ??? 
        {
            get => new List<object>(0);
            set => throw new InvalidOperationException("non-sense for a banana");
        }

        public List<object> ChemicalAgents { get; set; }  // ???

        public bool HasSpareParts   // ???
        {
            get => false; // really?
            set => throw new InvalidOperationException("non-sense for a banana");
        }
    }
}