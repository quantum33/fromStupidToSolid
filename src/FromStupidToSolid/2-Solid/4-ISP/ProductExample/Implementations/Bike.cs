using FromStupidToSolid.Solid.ISP.ProductExample.Abstractions;

namespace FromStupidToSolid.Solid.ISP.ProductExample.Implementations
{
    public class Bike : IFixableProduct, IMeasurableProduct
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool HasSpareParts { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }
    }
}