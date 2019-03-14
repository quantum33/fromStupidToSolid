namespace FromStupidToSolid.Solid.ISP.ProductExample.Abstractions
{
    public interface IMeasurableProduct : IProduct
    {
        int Height { get; set; }

        int Width { get; set; }
    }
}